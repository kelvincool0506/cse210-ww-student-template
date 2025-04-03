class Program
{
    static void Main(string[] args)
    {
        Activity breathing = new BreathingActivity("Breathing Exercise", "Relax and focus on your breathing.", 30);
        breathing.DisplayStartingMessage();
        ((BreathingActivity)breathing).Run();

        Activity listing = new ListingActivity("Listing Exercise", "List things that make you happy.", 60);
        ((ListingActivity)listing).Run();

        Activity reflecting = new ReflectingActivity("Reflecting Exercise", "Reflect on your recent achievements.", 90);
        ((ReflectingActivity)reflecting).Run();
    }
}
