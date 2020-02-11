/*
 * UTM DSS/USS API
 *
 * Interface to Discovery and Synchronization Service (DSS) and UAS Service Suppliers (USS) used by participating clients to discover and interoperate.  Unless otherwise specified, fields specified in a message but not declared in the API shall be ignored.
 *
 * OpenAPI spec version: 1.0.0-oas3
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using IO.Swagger.Attributes;
using IO.Swagger.Security;
using Microsoft.AspNetCore.Authorization;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class DSSOperationsApiController : ControllerBase
    { 
        /// <summary>
        /// /dss/operations
        /// </summary>
        /// <remarks>Retrieve all Operations in the given area during the given time.  Note that references to some Operations lying entirely outside the requested area may be returned as well.</remarks>
        /// <param name="area">The area in which to search for Operation entities.  References for some Operations near this area but wholly outside it may also be returned.</param>
        /// <param name="timeStart">If specified, indicates non-interest in any Operations that end before this time.  RFC 3339 format, per OpenAPI specification.</param>
        /// <param name="timeEnd">If specified, indicates non-interest in any Operations that start after this time.  RFC 3339 format, per OpenAPI specification.</param>
        /// <response code="200">Operations were successfully retrieved.</response>
        /// <response code="400">One or more input parameters were missing or invalid.</response>
        /// <response code="401">Bearer access token was not provided in Authorization header, token could not be decoded, or token was invalid.</response>
        /// <response code="403">The access token was decoded successfully but did not include a scope appropriate to this endpoint.</response>
        /// <response code="413">The requested area was too large.</response>
        [HttpGet]
        [Route("/v1/dss/operations")]
        [ValidateModelState]
        [SwaggerOperation("V1DssOperationsGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(SearchOperationReferenceResponse), description: "Operations were successfully retrieved.")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "One or more input parameters were missing or invalid.")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Bearer access token was not provided in Authorization header, token could not be decoded, or token was invalid.")]
        [SwaggerResponse(statusCode: 403, type: typeof(ErrorResponse), description: "The access token was decoded successfully but did not include a scope appropriate to this endpoint.")]
        [SwaggerResponse(statusCode: 413, type: typeof(ErrorResponse), description: "The requested area was too large.")]
        public virtual IActionResult V1DssOperationsGet([FromQuery][Required()]Polygon area, [FromQuery][Required()]Time timeStart, [FromQuery][Required()]Time timeEnd)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(SearchOperationReferenceResponse));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(ErrorResponse));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(ErrorResponse));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(ErrorResponse));

            //TODO: Uncomment the next line to return response 413 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(413, default(ErrorResponse));
            string exampleJson = null;
            exampleJson = "{\n  \"operation_references\" : [ {\n    \"owner\" : \"uss_owner\",\n    \"feedback_url\" : \"https://my_utm_uss.com/feedback\",\n    \"time_start\" : \"\",\n    \"ovn\" : \"\",\n    \"uss_may_be_down\" : true,\n    \"disabled\" : true,\n    \"id\" : \"\",\n    \"time_end\" : \"\",\n    \"details_url\" : \"https://my_utm_uss.com/operations\",\n    \"priority\" : 0\n  }, {\n    \"owner\" : \"uss_owner\",\n    \"feedback_url\" : \"https://my_utm_uss.com/feedback\",\n    \"time_start\" : \"\",\n    \"ovn\" : \"\",\n    \"uss_may_be_down\" : true,\n    \"disabled\" : true,\n    \"id\" : \"\",\n    \"time_end\" : \"\",\n    \"details_url\" : \"https://my_utm_uss.com/operations\",\n    \"priority\" : 0\n  } ]\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<SearchOperationReferenceResponse>(exampleJson)
                        : default(SearchOperationReferenceResponse);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// /dss/operations/{id}
        /// </summary>
        /// <remarks>Delete an Operation.</remarks>
        /// <param name="id">EntityUUID of the Operation.</param>
        /// <response code="200">The specified Operation was successfully removed from the DSS.</response>
        /// <response code="400">* One or more input parameters were missing or invalid. * The request attempted to mutate the Operation in a disallowed way.</response>
        /// <response code="401">Bearer access token was not provided in Authorization header, token could not be decoded, or token was invalid.</response>
        /// <response code="403">The access token was decoded successfully but did not include a scope appropriate to this endpoint.</response>
        [HttpDelete]
        [Route("/v1/dss/operations/{id}")]
        [ValidateModelState]
        [SwaggerOperation("V1DssOperationsIdDelete")]
        [SwaggerResponse(statusCode: 200, type: typeof(ChangeOperationReferenceResponse), description: "The specified Operation was successfully removed from the DSS.")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "* One or more input parameters were missing or invalid. * The request attempted to mutate the Operation in a disallowed way.")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Bearer access token was not provided in Authorization header, token could not be decoded, or token was invalid.")]
        [SwaggerResponse(statusCode: 403, type: typeof(ErrorResponse), description: "The access token was decoded successfully but did not include a scope appropriate to this endpoint.")]
        public virtual IActionResult V1DssOperationsIdDelete([FromRoute][Required]EntityUUID id)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ChangeOperationReferenceResponse));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(ErrorResponse));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(ErrorResponse));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(ErrorResponse));
            string exampleJson = null;
            exampleJson = "{\n  \"subscribers\" : [ {\n    \"subscriptions\" : [ {\n      \"subscription_id\" : \"\",\n      \"notification_index\" : 0\n    }, {\n      \"subscription_id\" : \"\",\n      \"notification_index\" : 0\n    } ],\n    \"url\" : \"\"\n  }, {\n    \"subscriptions\" : [ {\n      \"subscription_id\" : \"\",\n      \"notification_index\" : 0\n    }, {\n      \"subscription_id\" : \"\",\n      \"notification_index\" : 0\n    } ],\n    \"url\" : \"\"\n  } ],\n  \"operation_reference\" : \"\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<ChangeOperationReferenceResponse>(exampleJson)
                        : default(ChangeOperationReferenceResponse);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// /dss/operations/{id}
        /// </summary>
        /// <remarks>Retrieve Operation information from the DSS.</remarks>
        /// <param name="id">EntityUUID of the Operation.</param>
        /// <response code="200">Operation was retrieved successfully.</response>
        /// <response code="400">One or more input parameters were missing or invalid.</response>
        /// <response code="401">Bearer access token was not provided in Authorization header, token could not be decoded, or token was invalid.</response>
        /// <response code="403">The access token was decoded successfully but did not include a scope appropriate to this endpoint.</response>
        /// <response code="404">The requested Entity could not be found.</response>
        [HttpGet]
        [Route("/v1/dss/operations/{id}")]
        [ValidateModelState]
        [SwaggerOperation("V1DssOperationsIdGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(GetOperationReferenceResponse), description: "Operation was retrieved successfully.")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "One or more input parameters were missing or invalid.")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Bearer access token was not provided in Authorization header, token could not be decoded, or token was invalid.")]
        [SwaggerResponse(statusCode: 403, type: typeof(ErrorResponse), description: "The access token was decoded successfully but did not include a scope appropriate to this endpoint.")]
        [SwaggerResponse(statusCode: 404, type: typeof(ErrorResponse), description: "The requested Entity could not be found.")]
        public virtual IActionResult V1DssOperationsIdGet([FromRoute][Required]EntityUUID id)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(GetOperationReferenceResponse));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(ErrorResponse));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(ErrorResponse));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(ErrorResponse));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(ErrorResponse));
            string exampleJson = null;
            exampleJson = "{\n  \"operation_reference\" : {\n    \"owner\" : \"uss_owner\",\n    \"feedback_url\" : \"https://my_utm_uss.com/feedback\",\n    \"time_start\" : \"\",\n    \"ovn\" : \"\",\n    \"uss_may_be_down\" : true,\n    \"disabled\" : true,\n    \"id\" : \"\",\n    \"time_end\" : \"\",\n    \"details_url\" : \"https://my_utm_uss.com/operations\",\n    \"priority\" : 0\n  }\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<GetOperationReferenceResponse>(exampleJson)
                        : default(GetOperationReferenceResponse);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id">EntityUUID of the Operation.</param>
        /// <response code="200">An Operation was created successfully in the DSS.</response>
        /// <response code="400">* One or more input parameters were missing or invalid. * The request attempted to mutate the Operation in a disallowed way.</response>
        /// <response code="401">Bearer access token was not provided in Authorization header, token could not be decoded, or token was invalid.</response>
        /// <response code="403">The access token was decoded successfully but did not include a scope appropriate to this endpoint.</response>
        /// <response code="409">* The provided key did not prove knowledge of all current and relevant airspace Entities * An Operation with the specified ID already exists. * Despite repeated attempts, the DSS was unable to complete the update because of other simultaneous changes.</response>
        /// <response code="413">The area of the Operation is too large.</response>
        [HttpPut]
        [Route("/v1/dss/operations/{id}")]
        [ValidateModelState]
        [SwaggerOperation("V1DssOperationsIdPut")]
        [SwaggerResponse(statusCode: 200, type: typeof(ChangeOperationReferenceResponse), description: "An Operation was created successfully in the DSS.")]
        [SwaggerResponse(statusCode: 400, type: typeof(ErrorResponse), description: "* One or more input parameters were missing or invalid. * The request attempted to mutate the Operation in a disallowed way.")]
        [SwaggerResponse(statusCode: 401, type: typeof(ErrorResponse), description: "Bearer access token was not provided in Authorization header, token could not be decoded, or token was invalid.")]
        [SwaggerResponse(statusCode: 403, type: typeof(ErrorResponse), description: "The access token was decoded successfully but did not include a scope appropriate to this endpoint.")]
        [SwaggerResponse(statusCode: 409, type: typeof(AirspaceConflictResponse), description: "* The provided key did not prove knowledge of all current and relevant airspace Entities * An Operation with the specified ID already exists. * Despite repeated attempts, the DSS was unable to complete the update because of other simultaneous changes.")]
        [SwaggerResponse(statusCode: 413, type: typeof(ErrorResponse), description: "The area of the Operation is too large.")]
        public virtual IActionResult V1DssOperationsIdPut([FromBody]CreateOperationReferenceParameters body, [FromRoute][Required]EntityUUID id)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ChangeOperationReferenceResponse));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(ErrorResponse));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(ErrorResponse));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(ErrorResponse));

            //TODO: Uncomment the next line to return response 409 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(409, default(AirspaceConflictResponse));

            //TODO: Uncomment the next line to return response 413 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(413, default(ErrorResponse));
            string exampleJson = null;
            exampleJson = "{\n  \"subscribers\" : [ {\n    \"subscriptions\" : [ {\n      \"subscription_id\" : \"\",\n      \"notification_index\" : 0\n    }, {\n      \"subscription_id\" : \"\",\n      \"notification_index\" : 0\n    } ],\n    \"url\" : \"\"\n  }, {\n    \"subscriptions\" : [ {\n      \"subscription_id\" : \"\",\n      \"notification_index\" : 0\n    }, {\n      \"subscription_id\" : \"\",\n      \"notification_index\" : 0\n    } ],\n    \"url\" : \"\"\n  } ],\n  \"operation_reference\" : \"\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<ChangeOperationReferenceResponse>(exampleJson)
                        : default(ChangeOperationReferenceResponse);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}