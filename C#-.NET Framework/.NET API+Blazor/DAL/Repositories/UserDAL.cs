using DAL.DataContext;
using DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DAL.Repositories
{
    public class UserDAL
    {
        public List<Utilizador> GetAll()
        {
            var db = new Gcom2Context();
            return db.Utilizadores.ToList();
        }

        public Utilizador GetById(int Id)
        {
            var db = new Gcom2Context();
            Utilizador utilizador = new Utilizador();
            utilizador = db.Utilizadores.FirstOrDefault(x => x.Id == Id);
            return utilizador;
        }

        public void Update(Utilizador utilizador)
        {
            var db = new Gcom2Context();
            var obj = db.Update(utilizador);
            if (obj != null) db.SaveChanges();
        }
        public void AddUser([FromBody] Utilizador utilizador)
        {
            var db = new Gcom2Context();
            db.Add(utilizador);
            db.SaveChanges();
        }
        public void Delete(Utilizador utilizador)
        {

            var db = new Gcom2Context();
            var obj = db.Remove(utilizador);
        }
    }
}

