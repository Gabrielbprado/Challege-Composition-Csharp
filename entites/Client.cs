namespace ChallengeComposition.entites
{

    class Client
    {

        public string Name { get; set; } = "";
        public string Email { get; set; } = "";
        public DateTime BirthDate { get; set; }

        public Client(DateTime BirthDate,string Name,string Email)
        {
            this.BirthDate = BirthDate;
            this.Email = Email;
            this.Name = Name;
        }
        public Client()
        {
            
        }

       
    }

}