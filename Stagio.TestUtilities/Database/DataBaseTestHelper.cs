﻿using Stagio.DataLayer.EntityFramework;
using Stagio.Domain.Entities;

namespace Stagio.TestUtilities.Database
{
    public class DataBaseTestHelper
    {
        private EfEntityRepository<ApplicationUser> _userRepository;
        private EfEntityRepository<Student> _studentRepository;
        private EfEntityRepository<Coordinator> _coordonnatorRepository;
        private EfEntityRepository<Invitation> _invitationRepository;
        private EfEntityRepository<Stage> _stageRepository; 

         public DataBaseTestHelper()
        {
             _studentRepository = new EfEntityRepository<Student>();
            _userRepository = new EfEntityRepository<ApplicationUser>();
             _coordonnatorRepository = new EfEntityRepository<Coordinator>();
             _invitationRepository = new EfEntityRepository<Invitation>();
             _stageRepository = new EfEntityRepository<Stage>();
        }

        public void SeedTables()
        {
            addStudents();
            addUser();
            addCoordonnator();
            addInvitation();
            addStages();

        }

        private void addStages()
        {
            var stage1 = TestData.stage1;
            var stage2 = TestData.stage2;
            _stageRepository.Add(stage1);
            _stageRepository.Add(stage2);
        }

        private void addUser()
        {
            var user = TestData.applicationUser;
            _userRepository.Add(user);
 
        }

        private void addStudents()
        {
            var student1 = TestData.student1;
            _studentRepository.Add(student1);

            var student2 = TestData.student2;
            _studentRepository.Add(student2);

            var student3 = TestData.student3;
            _studentRepository.Add(student3);
        }

        private void addCoordonnator()
        {
            _coordonnatorRepository.Add(TestData.coordonnateur1);
        }

        private void addInvitation()
        {
            _invitationRepository.Add(TestData.invitation1);
        }

    }
}
