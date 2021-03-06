namespace DotNetDbMidterm
{
    class Ticket
    {
        //Ticket Class, Parent of tickets
        //overriden ToString for terminal output formatting
        //virtual GetFileLineString for easy file writing
        public int TicketID {get;}
        private string Summary {get; set;}
        private string Status {get; set;}
        private string Priority {get; set;}
        private string Submitter {get; set;}
        private string Assigned {get; set;}
        private string Watching {get ;set;}

        public Ticket(string ticketID, string summary, string status, string priority, string submitter, string assigned, string watching) {
            this.TicketID = System.Int32.Parse(ticketID);
            this.Summary = summary;
            this.Status = status;
            this.Priority = priority;
            this.Submitter = submitter;
            this.Assigned = assigned;
            this.Watching = watching;
            
        }
        public override string ToString() {
            return $"{this.TicketID,8}{this.Summary,10}{this.Status,7}{this.Priority,9}{this.Submitter,10}{this.Assigned,9}{this.Watching,20}";
        }
        public virtual string GetFileLineString() {
            return $"{this.TicketID},{this.Summary},{this.Status},{this.Priority},{this.Submitter},{this.Assigned},{this.Watching}";
        }
    }
}