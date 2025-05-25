using System.Media;

public class Sound
{
    public void TheSound()
    {
        SoundPlayer player = new SoundPlayer("shager.wav");
        player.PlaySync();
    }
}