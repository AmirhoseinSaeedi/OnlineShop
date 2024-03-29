﻿using Model.Dtos;
using Model.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Dtos;

namespace ViewModel
{
    public class PersonViewModel
    {

        private readonly PersonService _personService;

        public PersonViewModel()
        {
            _personService = new PersonService();
        }

        public dynamic FillGrid()
        {
            return _personService.Select();
        }

        public void Save(PersonSaveDto personSaveDto) 
        {
            var person = new Person()
            {
                FirstName = personSaveDto.FirstName,
                LastName = personSaveDto.LastName,
            };
            _personService.Insert(person);
        }

        public void Remove(PersonDeleteDto personDeleteDto) {
            var person = new Person()
            {
                Id = personDeleteDto.Id,
            };
            _personService.Delete(person);
        }

        public void Update(PersonUpdateDto personUpdateDto)
        {
            var person = new Person()
            {
                Id = personUpdateDto.Id,
                FirstName = personUpdateDto.NewFirstName,
                LastName = personUpdateDto.NewLastName,
            };
            _personService.Update(person);
        }
    }
}
