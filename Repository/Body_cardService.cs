using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Interfaces;
using WebApi.Models;
using WebApi.Persistences;

namespace WebApi.Repository
{
    public class Body_cardService : IBody_card
    {
        private readonly DbApiContext db;

        public Body_cardService(DbApiContext db)
        {
            this.db = db;
        }


        public Body_card AddOneBody_card(Body_card body_Card)
        {
            if (body_Card != null && Exists(body_Card.Id_Body_Card) == false)
            {
                db.Body_Cards.Add(body_Card);
            }
            else
            {
                body_Card = null;
            }
            return body_Card;
        }

        public bool Exists(int Id)
        {
            return db.Body_Cards.Any(e => e.Id_Body_Card == Id);
        }

        public async Task<IEnumerable<Body_card>> GetAllBody_card()
        {
            return await db.Body_Cards.Select(o=> new Body_card
            {
                Id_Body_Card = o.Id_Body_Card,
                 Url_Image = o.Url_Image,
                 Titre = o.Titre,
                 Detail=o.Detail,
                 Lien = o.Lien,
                 Numero = o.Numero,
            }).ToListAsync();
        }


    }

}
