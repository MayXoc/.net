namespace Coding.Exercise
{
    public class Guitar : Instrument
    {
        // This is how you override an abstract class. (Lesson: Abstract Classes)
        public override string Play()
        {
            return "Playing Guitar";
        }
    }
}