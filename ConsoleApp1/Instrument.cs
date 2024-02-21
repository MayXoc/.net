namespace Coding.Exercise
{
    // This is an abstract class which has concrete implementation and abstract methods etc. (Lesson: Abstract Classes)
    public abstract class Instrument
    {
        protected int volume = 50;

        // This is an abstract method which needs to be implemented in the baseclass. (Lesson: Abstract Classes)
        public abstract string Play();

        public void AdjustVolume(int newVolume)
        {
            if (newVolume < 0 || newVolume > 100)
            {
                throw new ArgumentOutOfRangeException("Volume must be between 0 and 100.");
            }

            volume = newVolume;
        }

        public int GetVolume()
        {
            return this.volume;
        }
    }
}