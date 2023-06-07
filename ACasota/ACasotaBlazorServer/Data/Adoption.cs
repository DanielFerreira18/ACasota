namespace ACasotaBlazorServer.Data
{
    //This class represents the adoption form
    public class Adoption
    {
        public string Id { get; set; }
        public bool HasAnimals { get; set; }
        
        //Proof of consent and responsability towards the animal
        public bool ConsentResponsability { get; set; }

        //Proprety used to describe the pets that it has
        public string AnimalDescription { get; set;}

        //Proprety used to describe the intentions behind the adoption form
        public string AdoptionReason { get; set;}


        //FK to the person trying to adopt
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        //FK to the animal being adopted
        public string AnimalId { get; set; }
        public Animal Animal { get; set; }

        //FK to the house of the person
        public string HouseId { get; set; }
        public AdoptionHouse House { get; set; }

    }
}
