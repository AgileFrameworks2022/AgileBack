using System.Collections.Generic;
using System.Text.Json.Serialization;
using GrupoWebBackend.DomainAdoptionsRequests.Domain.Models;
using GrupoWebBackend.DomainAdvertisements.Domain.Models;
using GrupoWebBackend.DomainDistrict.Domain.Models;
using GrupoWebBackend.DomainPets.Domain.Models;
using GrupoWebBackend.DomainPublications.Domain.Models;
using GrupoWebBackend.DomainReport;
using GrupoWebBackend.DomainSubscriptions.Domain.Models;

namespace GrupoWebBackend.Security.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string UserNick { get; set; }
        public string? Ruc { get; set; }
        public string? Dni { get; set; }
        public string? Phone { get; set; }
        public string Email { get; set; }
        
        public string? UrlToImageBackground { get; set; }
        public string? UrlToImageProfile { get; set; }
        public int? DistrictId { get; set; }

        public District District { get; set; }

        [JsonIgnore]
        public string PasswordHash { get; set; }

        public IList<Pet> Pets { get; set; } = new List<Pet>();
        public IList<Report> Reports { get; set; } = new List<Report>();
        public IList<Advertisement> Advertisements { get; set; } = new List<Advertisement>();
        public IList<Publication> Publications { get; set; }=new List<Publication>();
        public IList<AdoptionsRequests> AdoptionsRequestsList { get; set; } = new List<AdoptionsRequests>();

        public Subscription Subscription { get; set; }

        public bool IsAuthenticated()
        {
            return (this.Name != "" && this.LastName != "" && this.Phone != "" && this.Ruc != "" &&
                    this.Dni != "");
        }

        public bool IsReported()
        {
            return (this.Reports.Count > 0);
        }

    }
}