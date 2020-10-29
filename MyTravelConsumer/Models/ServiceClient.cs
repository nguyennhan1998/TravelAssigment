using MyTravelConsumer.TravelServiceReferences;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyTravelConsumer.Models
{
    public class ServiceClient
    {
        TravelServiceReferences.TravelServiceClient client = new TravelServiceReferences.TravelServiceClient();
        public List<Place> GetPlaces()
        {
            var list = client.GetPlaces().ToList();
            var rt = new List<Place>();
            list.ForEach(b => rt.Add(new Place()
            {
                id = b.id,
                PlaceName = b.PlaceName,
                PlaceAddress = b.PlaceAddress,
                PlaceInfo = b.PlaceInfo,
            }
            ));
            return rt;
        }
        public bool AddPlace(Place newPlace)
        {
            var place = new TravelServiceReferences.Place()
            {
                id = newPlace.id,
                PlaceAddress = newPlace.PlaceAddress,
                PlaceName = newPlace.PlaceName,
                PlaceInfo = newPlace.PlaceInfo,
                UserID = null,
                Status = 1,
            };
            return client.CreatePlace(place);
        }
        public bool EditPlace(Place newPlace)
        {
            var place = new TravelServiceReferences.Place()
            {
                id = newPlace.id,
                PlaceAddress = newPlace.PlaceAddress,
                PlaceName = newPlace.PlaceName,
                PlaceInfo = newPlace.PlaceInfo,
            };
            return client.EditPlace(place.id.ToString(),place);
        }
        public bool DeletePlace(string id)
        {
            return client.DeletePlace(id);
        }


        public List<Image> Images()
        {
            var list = client.GetImages().ToList();
            var rt = new List<Image>();
            list.ForEach(b => rt.Add(new Image()
            {
                id = b.id,
                ImageURL = b.ImageURL,
            }
            ));
            return rt;
        }
        public bool AddImage(Image newImage)
        {
            var image = new TravelServiceReferences.Image()
            {
                id = newImage.id,
                ImageURL = newImage.ImageURL,
                Status = newImage.Status,
                PlaceID = null,
                UserID = null,
            };
            return client.CreateImage(image);
        }
        public bool EditImage(Image newImage)
        {
            var image = new TravelServiceReferences.Image()
            {
                id = newImage.id,
                ImageURL = newImage.ImageURL,
                Status = newImage.Status,
                PlaceID = null,
                UserID = null,
            };
            return client.EditImage(image.id.ToString(), image);
        }
        public bool DeleteImage(string id)
        {
            return client.DeleteImage(id);
        }

        public List<Comment> Comments()
        {
            var list = client.GetComments().ToList();
            var rt = new List<Comment>();
            list.ForEach(b => rt.Add(new Comment()
            {
                id = b.id,
                CommentText = b.CommentText,
            }
            ));
            return rt;
        }
        public bool AddComment(Comment newComment)
        {
            var comment = new TravelServiceReferences.Comment()
            {
                id = newComment.id,
                CommentText = newComment.CommentText,
                CommentDate = newComment.CommentDate,
                PlaceID = null,
                UserID = null,
                Status = newComment.Status,
                Rating = newComment.Rating,
            };
            return client.CreateComment(comment);
        }
        public bool EditComment(Comment newComment)
        {
            var comment = new TravelServiceReferences.Comment()
            {
                id = newComment.id,
                CommentText = newComment.CommentText,
                CommentDate = newComment.CommentDate,
                PlaceID = null,
                UserID = null,
                Status = newComment.Status,
                Rating = newComment.Rating,
            };
            return client.EditComment(comment.id.ToString(), comment);
        }
        public bool DeleteComment(string id)
        {
            return client.DeleteComment(id);
        }
    }
}