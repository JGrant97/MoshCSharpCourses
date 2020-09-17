using System;

namespace Access_Modifiers
{
    public class Person
    {
        private DateTime _birthDate = new DateTime();

        public void SetBirthdate(DateTime birthdate)
        {
            _birthDate = birthdate;
        }

        public DateTime GetBirthdate()
        {
            return _birthDate;
        }
    }
}
