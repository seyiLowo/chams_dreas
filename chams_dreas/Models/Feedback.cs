using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using chams_dreas.Enum;

namespace chams_dreas.Models
{
class Feedback : BaseModel
    {
        public Guid FeedbackID { get; set; }
        public Guid clientID;
        public Guid serviceProviderID;

        public Property PropertyID { get; set; }
        public string FeedbackMessage { get; set; }
        public User user;

        private Roles roles;


        public Feedback(Roles roles, User user)
        {
            this.user = user;
            this.roles = roles;

            switch (roles)
            {
                case Roles.client:
                    clientID = user.UserID;
                    break;
                case Roles.agent:
                    serviceProviderID = user.UserID;
                    break;
                case Roles.landlord:
                    serviceProviderID = user.UserID;
                    break;
                case Roles.insurance:
                    serviceProviderID = user.UserID;
                    break;
                case Roles.digitalLegal:
                    serviceProviderID = user.UserID;
                    break;
                case Roles.artisan:
                    serviceProviderID = user.UserID;
                    break;
                default:
                    break;
            }
        }





    }
}
