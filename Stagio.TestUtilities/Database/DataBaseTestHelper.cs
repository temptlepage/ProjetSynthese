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
        private EfEntityRepository<ContactEnterprise> _contactEnterpriseRepository; 
        private EfEntityRepository<Stage> _stageRepository;
        private EfEntityRepository<Apply> _applyRepository;

         public DataBaseTestHelper()
        {
             _studentRepository = new EfEntityRepository<Student>();
            _userRepository = new EfEntityRepository<ApplicationUser>();
             _coordonnatorRepository = new EfEntityRepository<Coordinator>();
             _invitationRepository = new EfEntityRepository<Invitation>();
             _contactEnterpriseRepository = new EfEntityRepository<ContactEnterprise>();
             _stageRepository = new EfEntityRepository<Stage>();
             _applyRepository = new EfEntityRepository<Apply>();
        }

        public void SeedTables()
        {
            addStudents();
            addUser();
            addCoordonnator();
            addInvitation();
            addEnterprises();
            addStages();
            addApplies();
        }

        private void addApplies()
        {
            var apply1 = TestData.apply1;
            _applyRepository.Add(apply1);
        }

        private void addStages()
        {
            var stage1 = TestData.stage1;
            var stage2 = TestData.stage2;
            var stage3 = TestData.stage3;
            _stageRepository.Add(stage1);
            _stageRepository.Add(stage3);
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

        private void addEnterprises()
        {
            _contactEnterpriseRepository.Add(TestData.contactEnterprise1);
            _contactEnterpriseRepository.Add(TestData.contactEnterprise2);
        }

    }
}
