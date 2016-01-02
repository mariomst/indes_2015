package restcomponent;

//Bibliotecas necessarias:
import java.io.IOException;
import java.util.List;
import java.util.Map;

import javax.json.Json;
import javax.json.JsonObject;
import javax.json.JsonReader;
import javax.servlet.http.HttpServletRequest;
import javax.ws.rs.GET;
import javax.ws.rs.POST;
import javax.ws.rs.Path;
import javax.ws.rs.Produces;
import javax.ws.rs.core.Context;
import javax.ws.rs.core.Response;

import javolution.util.FastMap;

import org.ofbiz.base.util.Debug;
import org.ofbiz.base.util.UtilMisc;
import org.ofbiz.entity.DelegatorFactory;
import org.ofbiz.entity.GenericDelegator;
import org.ofbiz.entity.GenericEntityException;
import org.ofbiz.entity.GenericValue;
import org.ofbiz.service.GenericServiceException;
import org.ofbiz.service.LocalDispatcher;

@Path("/score")
public class BattleshipsResource 
{
	@Context
	HttpServletRequest httpRequest;
	
	//Funcao para retornar todos os scores registados
	@GET
	@Produces("application/json")
	public Response getAllScores()
	{
		String username = null;
		String password = null;
		
		try 
		{
			username = httpRequest.getHeader("login.username");
			password = httpRequest.getHeader("login.password");
		} 
		catch (NullPointerException e) 
		{
			return Response.serverError().entity("Problem reading http header(s): login.username or login.password").build();
		}
		
		if (username == null || password == null) 
		{
			return Response.serverError().entity("Problem reading http header(s): login.username or login.password").build();
		}
		
		GenericDelegator delegator = (GenericDelegator) DelegatorFactory.getDelegator("default");
		List<GenericValue> scores  = null;
		
		try 
		{
			scores = delegator.findAll("Score", false);
		} 
		catch (GenericEntityException e) 
		{
			return Response.serverError().entity(e.toString()).build();
		}
		
		if (scores != null) 
		{
			String response = Util.convertListGenericValueToJSON(scores);

			if (response == null) 
			{
				return Response.serverError().entity("Info: Erro na conversao do JSON!").build();
			}

			return Response.ok(response).type("application/json").build();
		}
		
		throw new RuntimeException("Invalid ");
	}
	
	//Funcao para inserir um novo score
	@POST
	@Produces("application/json")
	public Response addScore()
	{
		String username = null;
		String password = null;
		
		try 
		{
			username = httpRequest.getHeader("login.username");
			password = httpRequest.getHeader("login.password");
		} 
		catch (NullPointerException e) 
		{
			return Response.serverError().entity("Problem reading http header(s): login.username or login.password").build();
		}
		
		if (username == null || password == null) 
		{
			return Response.serverError().entity("Problem reading http header(s): login.username or login.password").build();
		}
		
		JsonReader jsonReader;		
		try 
		{
			jsonReader = Json.createReader(httpRequest.getReader());
		} 
		catch (IOException e) 
		{
			return Response.serverError().entity("Problem reading json body").build();
		}
		
		JsonObject jsonObj = jsonReader.readObject();
		
		GenericDelegator delegator = (GenericDelegator) DelegatorFactory.getDelegator("default");
		LocalDispatcher dispatcher = org.ofbiz.service.ServiceDispatcher.getLocalDispatcher("default", delegator);

		Map<String, String> paramMap = UtilMisc.toMap(
				"username", jsonObj.getString("username"),
				"hits", jsonObj.getString("hits"),
				"misses", jsonObj.getString("misses"),
				"hitsPercet", jsonObj.getString("hitsPercet"),
				"winner", jsonObj.getString("winner"),
				"login.username",username, 
				"login.password", password);

		Map<String, Object> result = FastMap.newInstance();
		try 
		{
			result = dispatcher.runSync("addScore", paramMap);
		} 
		catch (GenericServiceException e1) 
		{
			Debug.logError(e1, PingResource.class.getName());
			return Response.serverError().entity(e1.toString()).build();
		}

		String scoreId = result.get("scoreId").toString();
		String score   = Util.getScore(scoreId);
		if (score != null) 
		{
			return Response.ok(score).type("application/json").build();
		} 
		else 
		{
			return Response.serverError().entity("Problem reading the new recipe after created!").build();
		}
	}
}
