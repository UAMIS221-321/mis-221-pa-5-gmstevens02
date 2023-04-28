namespace mis_221_pa_5_gmstevens02
{
    public class Listing
    {
        private int listingID;
        private string trainerName;
        private int sessionDate;
        private int sessionTime;
        private int sessionCost;
        private string listingAvailability;

        public Listing()
        {

        }

        public Listing(int listingID, string trainerName, int sessionDate, int sessionTime, int sessionCost, string listingAvailability)
        {
            this.listingID = listingID;
            this.trainerName = trainerName;
            this.sessionDate = sessionDate;
            this.sessionTime = sessionTime;
            this.sessionCost = sessionCost;
            this.listingAvailability = listingAvailability;
        }
        //SetListingID
        public void SetListingID(int listingID)
        {
            this.listingID = listingID;
        }
        //GetListingID
        public int GetListingID()
        {
            return listingID;
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
        //SetSessionDate
        public void SetSessionDate(int sessionDate)
        {
            this.sessionDate = sessionDate;
        }
        //GetSessionDate
        public int GetSessionDate()
        {
            return sessionDate;
        }
        //SetSessionTime
        public void SetSessionTime(int sessionTime)
        {
            this.sessionTime = sessionTime;
        }
        //GetSessionTime
        public int GetSessionTime()
        {
            return sessionTime;
        }
        //SetSessionCost
        public void SetSessionCost(int sessionCost)
        {
            this.sessionCost = sessionCost;
        }
        //GetSessionCost
        public int GetSessionCost()
        {
            return sessionCost;
        }
        //SetListingAvailability
        public void SetListingAvailability(string listingAvailability)
        {
            this.listingAvailability = listingAvailability;
        }
        //GetListingAvailability
        public string GetListingAvailability()
        {
            return listingAvailability;
        }
    }
}