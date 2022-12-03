using Tasks.Util;

namespace Tasks._5._1;

public class Program : BaseProgram
{
    private Store _store;

    private const int EXIT_ACTION = 0;
    private const int CREATE_AUDIO_ACTION = 1;
    private const int CREATE_DVD_ACTION = 2;
    public Program()
    {
        _store = new Store(Input.ReadNotEmptyString("Enter store name: "),Input.ReadNotEmptyString("Enter store address: "));

        int choice;
        while (true)
        {
            Console.WriteLine("Choose action:\n" + 
                              EXIT_ACTION + ". Exit program.\n" +
                              CREATE_AUDIO_ACTION + ". Create new audio.\n" +
                              CREATE_DVD_ACTION + ". Create new dvd.");
            choice = Input.ReadIntInRange("perform action: ", 0, 2);
            if (choice == EXIT_ACTION)
                break;
            PerformAction(choice);
            Console.WriteLine(_store);
        }

    }

    private void PerformAction(int action)
    {
        switch (action)
        {
            case CREATE_AUDIO_ACTION:
                CreateAudio();
                break;
            case CREATE_DVD_ACTION:
                CreateDVD();
                break;
            default:
                throw new ArgumentException("Unexpected action: " + action);
        }
    }

    private void CreateAudio()
    {
        string artist = Input.ReadNotEmptyString("Enter artist: ");
        string recordingStudio = Input.ReadNotEmptyString("Enter recording studio: ");
        int songsAmount = Input.ReadInt("Enter number of songs: ");
        string name = Input.ReadNotEmptyString("Enter name: ");
        string genre = Input.ReadNotEmptyString("Enter genre: ");
        _store += new Audio(artist,recordingStudio,songsAmount,name,genre);
    }
    
    private void CreateDVD()
    {
        string producer = Input.ReadNotEmptyString("Enter producer: ");
        string filmCompany = Input.ReadNotEmptyString("Enter film company: ");
        int minutes = Input.ReadInt("Enter duration in minutes: ");
        string name = Input.ReadNotEmptyString("Enter name: ");
        string genre = Input.ReadNotEmptyString("Enter genre: ");
        _store += new DVD(producer,filmCompany,minutes,name,genre);
    }
}