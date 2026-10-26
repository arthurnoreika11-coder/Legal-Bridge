import system;
import system.text.regularExpressions;

public class EmailWorker
{
    public static void EmailClass(string[] args)
    {
        public int messageID;
        public string recipientEmail;
        public string messageSubject;
        public string messageBody;
        public int matterNumber;
        public HtmlString emailTotal;

        private int ParseMatterNumber(string subject)
        {
            string pattern = @"\b\d{6}\b";
            Match match = Regex.Match(subject, pattern);
            if (match.Success)
            {
                return int.Parse(match.Value);
            }
            else
            {
                throw new FormatException("No valid matter number found in the subject.");
            }
        }

        public Email(int id, string email, string subject, string body, HtmlString total)
        {
            messageID = id;
            recipientEmail = email;
            messageSubject = subject;
            messageBody = body;
            matterNumber = ParseMatterNumber(subject);
            emailTotal = total;
        }
    }
}