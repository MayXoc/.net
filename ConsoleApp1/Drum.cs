namespace Coding.Exercise
{
    public class Drum : Instrument
    {
        // This is how you override an abstract class. (Lesson: Abstract Classes)
        public override string Play()
        {
            return "Playing Drum";
        }
    }
}