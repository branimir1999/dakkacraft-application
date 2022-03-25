using DakkacraftBLL.Models;
using DakkacraftDAL.Models;
using DakkacraftDAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DakkacraftBLL.Services
{
    class VerificationUserServices : IVerificationUserServices
    {
        private readonly IRepository<VerificationUserDB> _repository;
        private readonly Random random = new Random();

        private const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

        public VerificationUserServices(IRepository<VerificationUserDB> repository)
        {
            _repository = repository;
        }

        public String createVerificationCode()
        {
            var stringChars = new char[6];

            for (int i = 0; i < stringChars.Length; i++) {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            return new String(stringChars);
        }

        // Tu dobivamo DTO request?
        public void createVerificationUser(VerificationRequestDTO verificationRequestDTO)
        {
            String verificationCode = createVerificationCode();
            VerificationUserDB new_user = new VerificationUserDB
            {
                // Hoce li se Guid automatski generirati?
                Uuid = verificationRequestDTO.Uuid,
                Username = verificationRequestDTO.Username,
                VerificationCode = verificationCode,
                Verified = false,
                Update = false
            };

            // Dodajemo novog usera u databazu
            _repository.AddEntity(new_user);

            // Saljemo odgovor
            VerificationCodeDTO responseDTO = new VerificationCodeDTO
            {
                VerificationCode = verificationCode
            };
            // SendResponse(responseDTO)
        }


        public void setVerificationUser(VerificationUserDB verificationUserDB)
        {
            // Ovako se updatea item u DB?
            verificationUserDB.Verified = true;
            _repository.Save();
            throw new NotImplementedException();
        }

        public void verifyVerificationCode(PostVerifyUserDTO postVerifyUserDTO)
        {
            // TODO: automapper za pretvorbu izmedu UserDB i UserDTO
            VerificationUserDB user = _repository.GetEntities().Where(e => e.VerificationCode == postVerifyUserDTO.VerificationCode).FirstOrDefault();

            ResponseVerifyUserDTO responseDTO = null;
            if (user != null) { // Found a match
                responseDTO = new ResponseVerifyUserDTO
                {
                    Uuid = postVerifyUserDTO.Uuid,
                    status = 0,
                    Username = user.Username
                };

                setVerificationUser(user);
            } else {
                responseDTO = new ResponseVerifyUserDTO
                {
                    Uuid = postVerifyUserDTO.Uuid,
                    status = 1,
                    Username = "" // Ima bolji nacin za ovo ali mi se neda razmisljati
                };
            }

            // SendResponse(responseDTO)
        }
    }
}
