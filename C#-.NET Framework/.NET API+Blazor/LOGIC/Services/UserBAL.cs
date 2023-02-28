using DAL.Repositories;
using AutoMapper;
using DAL.Entities;
using BAL.Models;
using BAL.Dtos;
using System.Linq.Expressions;

namespace BAL.Services
{
    public class UserBAL
    {
        public UserDAL _UserDAL;
        public Mapper _UserMapper;
        public Mapper _UserActiveMapper;

        public UserBAL()
        {
            _UserDAL = new UserDAL();
            var configUser = new MapperConfiguration(cfg => cfg.CreateMap<Utilizador, UtilizadorModel>().ReverseMap());
            var configActiveUser = new MapperConfiguration(cfg =>cfg.CreateMap<Utilizador, UtilizadorActivo>().ReverseMap());
            _UserMapper = new Mapper(configUser);
            _UserActiveMapper = new Mapper(configActiveUser);
        }

        public UserResponseDto GetAllUsers(int page)
        {
            List<Utilizador> usersFromDB = _UserDAL.GetAll();
            try
            {
                var pageResults = 20f;
                var pageCount = Math.Ceiling(usersFromDB.Count() / pageResults);

                List<UtilizadorModel> peopleModel = _UserMapper.Map<List<Utilizador>, List<UtilizadorModel>>(usersFromDB)
                            .Skip((page - 1) * (int)pageResults)
                            .Take((int)pageResults)
                            .ToList();

                var response = new UserResponseDto
                {
                    UtilizadoresDto = peopleModel,
                    CurrentPage = page,
                    Pages = (int)pageCount
                };
                return response;
            }
            catch (Exception)
            {

                throw new Exception("Error getting all users");
            }
        }

        public ActiveUserResponseDto GetAllActiveUsers(int page)
        {

            List<Utilizador> usersFromDB = _UserDAL.GetAll().Where(u => u.Activo == true).ToList();
            var pageResults = 20f;
            var pageCount = Math.Ceiling(usersFromDB.Count() / pageResults);

            List<UtilizadorActivo> activeUsersModel = _UserActiveMapper.Map<List<Utilizador>,List<UtilizadorActivo>>(usersFromDB)
                        .Skip((page - 1) * (int)pageResults)
                        .Take((int)pageResults)
                        .ToList();

            var response = new ActiveUserResponseDto
            {
                UtilizadoresActivosDto = activeUsersModel,
                CurrentPage = page,
                Pages = (int)pageCount
            };

            return response;
        }

        public UtilizadorModel GetById(int id)
        {
            var userEntity = _UserDAL.GetById(id);
            UtilizadorModel utilizadorModel = _UserMapper.Map<Utilizador, UtilizadorModel>(userEntity);
            return utilizadorModel;
        }

        public void AddUser(UtilizadorModel utilizadorModel)
        {
            Utilizador userEntity = _UserMapper.Map<UtilizadorModel, Utilizador>(utilizadorModel);
            try
            {
                if(userEntity != null)
                {
                    _UserDAL.AddUser(userEntity);
                }
            }
            catch (Exception)
            {

                throw new Exception ("User is null");
            }

        }

        public void UpdateUser(UtilizadorModel utilizadorModel)
        {
            if (utilizadorModel == null)
                throw new ArgumentNullException(nameof(utilizadorModel));

            Utilizador userEntity = _UserMapper.Map<UtilizadorModel, Utilizador>(utilizadorModel);
            var obj = _UserDAL.GetById(userEntity.Id);

            if (obj == null)
                throw new ArgumentException("Utilizador not found");

            obj = _UserMapper.Map<Utilizador, Utilizador>(userEntity);
            _UserDAL.Update(obj);
        }


        public void DeleteUser(int Id)          
        {             
            try             
            {                 
                if (Id != 0)                 
                {                     
                    var obj = _UserDAL.GetById(Id);
                    _UserDAL.Delete(obj);                 
                }             
            }             
            catch (Exception) 
            {                 
                throw new Exception("User not found");             
            }
        }


    }
}
