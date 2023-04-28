namespace mis_221_pa_5_gmstevens02
{
    public class Trainer
    {
        private int trainerID;
        private string trainerName;
        private string mailingAddress;
        private string trainerEmailAddress;
        //no arg constructor
        public Trainer() 
        {

        }

        //constructor
        public Trainer(int trainerID, string trainerName, string mailingAddress, string trainerEmailAddress)
        {
            this.trainerID = trainerID;
            this.trainerName = trainerName;
            this.mailingAddress = mailingAddress;
            this.trainerEmailAddress = trainerName;
        }
        //SetTrainerID
        public void SetTrainerID(int trainerID)
        {
            this.trainerID = trainerID;
        }
        //GetTrainerID
        public int GetTrainerID()
        {
            return trainerID;
        }
        //SetTrainerName
        public void SetTrainerName(string trainerName)
        {
            this.trainerName = trainerName;
        }
        //GetTrainerName
        public string GetTrainerName()
        {
            return trainerName;
        }
        //SetMailingAddress
        public void SetMailingAddress(string mailingAddress)
        {
            this.mailingAddress = mailingAddress;
        }
        //GetMailingAddress
        public string GetMailingAddress()
        {
            return mailingAddress;
        }
        //SetTrainerEmailAddress
        public void SetTrainerEmailAddress(string trainerEmailAddress)
        {
            this.trainerEmailAddress = trainerEmailAddress;
        }
        //GetTrainerEmailAddress
        public string GetTrainerEmailAddress()
        {
            return trainerEmailAddress;
        }
        //ToString
        public override string ToString()
        {
            return $"{this.trainerName}'s Trainer ID is {this.trainerID}, their email is {this.trainerEmailAddress}, and their mailing address is {this.mailingAddress}";
        }
    }
}