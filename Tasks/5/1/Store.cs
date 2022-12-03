namespace Tasks._5._1;

public class Store
{
    private string _name;
    private string _address;
    private List<Audio> _audios;
    private List<DVD> _DVDs;

    public Store(string name, string address)
    {
        _name = name;
        _address = address;
        _audios = new List<Audio>();
        _DVDs = new List<DVD>();
    }

    public static Store operator +(Store store, Audio audio)
    {
        store._audios.Add(audio);
        return store;
    }
    public static Store operator +(Store store, DVD dvd)
    {
        store._DVDs.Add(dvd);
        return store;
    }
    
    public static Store operator -(Store store, Audio audio)
    {
        store._audios.Remove(audio);
        return store;
    }
    public static Store operator -(Store store, DVD dvd)
    {
        store._DVDs.Remove(dvd);
        return store;
    }
    
    public override string ToString()
    {
        string result = _name + " at " + _address + "\nAudio:";
        foreach (Audio audio in _audios)
        {
            result += "\n" + audio + ";";
        }
        result += "\nFilms:";
        foreach (DVD dvd in _DVDs)
        {
            result += "\n" + dvd + ";";
        }
        return result;
    }
}