using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MyTravelServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITravelService" in both code and config file together.
    [ServiceContract]
    public interface ITravelService
    {
        //Place
        [OperationContract] 
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json, 
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare, 
            UriTemplate = "api/v1/GetPlaceList"
          )] 
        List<Place> GetPlaces();

        [OperationContract]
        [WebInvoke(Method = "POST",
         ResponseFormat = WebMessageFormat.Json, 
         RequestFormat = WebMessageFormat.Json,
         BodyStyle = WebMessageBodyStyle.Bare, 
         UriTemplate = "api/v1/CreatePlace"
       )]
        bool CreatePlace(Place newPlace);

        [OperationContract]
        [WebInvoke(Method = "POST",
         ResponseFormat = WebMessageFormat.Json,
         RequestFormat = WebMessageFormat.Json,
         BodyStyle = WebMessageBodyStyle.Bare,
         UriTemplate = "api/v1/EditPlace/{id}"
       )]
        bool EditPlace(string id, Place newPlace);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "api/v1/Delete/{id}"
      )]
        bool DeletePlace(string id);

        // Images
        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "api/v1/GetImagesList"
          )]
        List<Image> GetImages();

        [OperationContract]
        [WebInvoke(Method = "POST",
         ResponseFormat = WebMessageFormat.Json,
         RequestFormat = WebMessageFormat.Json,
         BodyStyle = WebMessageBodyStyle.Bare,
         UriTemplate = "api/v1/CreateImage"
       )]
        bool CreateImage(Image newImage);

        [OperationContract]
        [WebInvoke(Method = "POST",
         ResponseFormat = WebMessageFormat.Json,
         RequestFormat = WebMessageFormat.Json,
         BodyStyle = WebMessageBodyStyle.Bare,
         UriTemplate = "api/v1/EditImage/{id}"
       )]
        bool EditImage(string id, Image newImage);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "api/v1/DeleteImage/{id}"
      )]
        bool DeleteImage(string id);

        //Comment 
        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "api/v1/GetCommentList"
          )]
        List<Comment> GetComments();

        [OperationContract]
        [WebInvoke(Method = "POST",
         ResponseFormat = WebMessageFormat.Json,
         RequestFormat = WebMessageFormat.Json,
         BodyStyle = WebMessageBodyStyle.Bare,
         UriTemplate = "api/v1/CreateComment"
       )]
        bool CreateComment(Comment newComment);

        [OperationContract]
        [WebInvoke(Method = "POST",
         ResponseFormat = WebMessageFormat.Json,
         RequestFormat = WebMessageFormat.Json,
         BodyStyle = WebMessageBodyStyle.Bare,
         UriTemplate = "api/v1/EditComment/{id}"
       )]
        bool EditComment(string id, Comment newComment);

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "api/v1/DeleteComment/{id}"
      )]
        bool DeleteComment(string id);
    }
}
