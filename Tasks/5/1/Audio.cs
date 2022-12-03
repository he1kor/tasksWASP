namespace Tasks._5._1;

public class Audio : Disk
{
    protected string Artist;
    protected string RecordingStudio;
    protected int SongsAmount;

    public override int DiskSize => 8 * SongsAmount;

    public Audio(string artist, string recordingStudio, int songsAmount, string name, string genre) : base(name, genre)
    {
        Artist = artist;
        RecordingStudio = recordingStudio;
        SongsAmount = songsAmount;
    }

    public override void Burn(params string[] values)
    {
        SongsAmount = values.Length;
        BurnCount++;
    }

    public override string ToString()
    {
        return Name + " (" + Genre + ") by " + Artist + " recorded in " + RecordingStudio + ". Number of songs: " + SongsAmount + "; burn count: " + BurnCount;
    }
}