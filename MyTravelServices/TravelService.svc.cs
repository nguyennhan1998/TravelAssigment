using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MyTravelServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TravelService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select TravelService.svc or TravelService.svc.cs at the Solution Explorer and start debugging.
    public class TravelService : ITravelService
    {
        TravelDataContext data = new TravelDataContext();

        public bool CreateComment(Comment newComment)
        {
            try
            {
                data.Comments.InsertOnSubmit(newComment);
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public bool CreateImage(Image newImage)
        {
            try
            {
                data.Images.InsertOnSubmit(newImage);
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public bool CreatePlace(Place newPlace)
        {
            try
            {
                data.Places.InsertOnSubmit(newPlace);
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public bool DeleteComment(string id)
        {
            try
            {
                var comment = data.Comments.Where(b => b.id == int.Parse(id)).FirstOrDefault();
                data.Comments.DeleteOnSubmit(comment);
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public bool DeleteImage(string id)
        {
            try
            {
                var image = data.Images.Where(b => b.id == int.Parse(id)).FirstOrDefault();
                data.Images.DeleteOnSubmit(image);
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public bool DeletePlace(string id)
        {
            try
            {
                var place = data.Places.Where(b => b.id == int.Parse(id)).FirstOrDefault();
                data.Places.DeleteOnSubmit(place);
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public bool EditComment(string id, Comment newComment)
        {
            try
            {
                var comment = data.Comments.Where(b => b.id == int.Parse(id)).FirstOrDefault();
                data.Comments.DeleteOnSubmit(comment);
                data.Comments.InsertOnSubmit(newComment);
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public bool EditImage(string id, Image newImage)
        {
            try
            {
                var image = data.Images.Where(b => b.id == int.Parse(id)).FirstOrDefault();
                data.Images.DeleteOnSubmit(image);
                data.Images.InsertOnSubmit(newImage);
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public bool EditPlace(string id, Place newPlace)
        {
            try
            {
                var place = data.Places.Where(b => b.id == int.Parse(id)).FirstOrDefault();
                data.Places.DeleteOnSubmit(place);
                data.Places.InsertOnSubmit(newPlace);
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public List<Comment> GetComments()
        {
            try
            {
                var comments = (from comment in data.Comments select comment).ToList();
                return comments;
            }
            catch { return null; }
        }

        public List<Image> GetImages()
        {
            try
            {
                var images = (from image in data.Images select image).ToList();
                return images;
            }
            catch { return null; }
        }

        public List<Place> GetPlaces()
        {
            try
            {
                var places = (from place in data.Places select place).ToList();
                return places;
            }
            catch { return null; }
        }
    }
}
