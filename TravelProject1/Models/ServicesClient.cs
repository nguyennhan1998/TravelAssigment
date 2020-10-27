using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TravelProject1.TravelServiceReferences;

namespace TravelProject1.Models
{
    public class ServicesClient
    {
        TravelServiceClient client = new TravelServiceClient();
        public List<Location> getAllLocations()
        {
            var list = client.GetLocation().ToList();
            var rt = new List<Location>();
            list.ForEach(b => rt.Add(new Location()
            {
                id = b.id,
                LocationAddress = b.LocationAddress,
                LocationDescription = b.LocationDescription,
                LocationName = b.LocationName,
                Status = b.Status,
            }
           ) );
                return rt;
            
        }
        public List<Post> getAllPosts()
        {
            var list = client.GetPosts().ToList();
            var rt = new List<Post>();
            list.ForEach(b => rt.Add(new Post()
            {
                id = b.id,
                Title = b.Title,
                Description = b.Description,
                PostDate = b.PostDate,
                Status = b.Status,
            }
            ));
            return rt;
        }
        public List<Comment> getAllComments()
        {
            var list = client.GetComments().ToList();
            var rt = new List<Comment>();
            list.ForEach(b => rt.Add(new Comment()
            {
                id = b.id,
                CommentInfo = b.CommentInfo,
                CommentDate = b.CommentDate,
                Status = b.Status,
                Rating = b.Rating,
            }
            ));
            return rt;
        }
        public List<Image> getAllImages()
        {
            var list = client.GetImages().ToList();
            var rt = new List<Image>();
            list.ForEach(b => rt.Add(new Image()
            {
                id = b.id,
                imageurl = b.imageurl,

            }
            ));
            return rt;
        }
        public bool AddLocation(Location newLocation)
        {
            var location = new TravelServiceReferences.Location()
            {
                id = newLocation.id,
                LocationName = newLocation.LocationName,
                LocationDescription = newLocation.LocationDescription,
                LocationAddress = newLocation.LocationAddress,
                Status = newLocation.Status,
            };
            return client.AddLocation(location);
        }
        public bool AddPost(Post newPost)
        {
            var post = new TravelServiceReferences.Post()
            {
                id = newPost.id,
                Title = newPost.Title,
                Description = newPost.Description,
                PostDate = newPost.PostDate,
                LocationID = newPost.location.id,

            };
            return client.AddPost(post);
        }
        public bool AddComment(Comment newComment)
        {
            var comment = new TravelServiceReferences.Comment()
            {
                id = newComment.id,
                CommentInfo = newComment.CommentInfo,
                CommentDate = newComment.CommentDate,
                PostID = newComment.Post.id,
                Status = newComment.Status,
                Rating = newComment.Rating,

            };
            return client.AddComment(comment);
        }
        public bool AddImage(Image newImage)
        {
            var image = new TravelServiceReferences.Image()
            {
                id = newImage.id,
                imageurl = newImage.imageurl,
                LocationID = newImage.Location.id,


            };
            return client.AddImage(image);
        }
        public bool EditLocation(Location newLocation)
        {
            var location = new TravelServiceReferences.Location()
            {
                id = newLocation.id,
                LocationAddress = newLocation.LocationAddress,
                LocationName = newLocation.LocationName,
                LocationDescription = newLocation.LocationDescription,
                Status = newLocation.Status,
            };
            return client.EditLocation(location.id.ToString(), location);

        }
        public bool EditPost(Post newPost)
        {
            var post = new TravelServiceReferences.Post()
            {
                id = newPost.id,
                Title = newPost.Title,
                Description = newPost.Description,
                PostDate = newPost.PostDate,
                LocationID = newPost.location.id,
            };
            return client.EditPost(post.id.ToString(), post);
        }
        public bool EditComment(Comment newComment)
        {
            var comment = new TravelServiceReferences.Comment()
            {
                id = newComment.id,
                CommentInfo = newComment.CommentInfo,
                CommentDate = newComment.CommentDate,
                PostID = newComment.Post.id,
                Status = newComment.Status,
                Rating = newComment.Rating,
            };
            return client.EditComment(comment.id.ToString(), comment);
        }
        public bool EditImage(Image newImage)
        {
            var image = new TravelServiceReferences.Image()
            {
                id = newImage.id,
                imageurl = newImage.imageurl,
                LocationID = newImage.Location.id,
            };
            return client.EditImage(image.id.ToString(), image);
        }

        public bool DeleteLocation(string id)
        {
            return client.DeleteLocation(id);
        }
        public bool DeletePost(string id)
        {
            return client.DeletePost(id);

        }
        public bool DeleteComment(string id)
        {
            return client.DeleteComment(id);

        }
        public bool DeleteImage(string id)
        {
            return client.DeleteImage(id);

        }
    }
}