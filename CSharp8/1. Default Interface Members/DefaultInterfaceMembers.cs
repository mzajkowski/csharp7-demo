namespace CSharp8._1._Default_Interface_Members
{
    public interface ICanHasDefaultMembers
    {
        void FireDev();

        void FireAllDevs()
        {
            foreach (var dev in theCogworks)
            {
                FireDev();
            }
        }
    }

    public class MySweetClassWhichIDontWantToModify : ICanHasDefaultMembers
    {
        public void FireDev()
        {
            // Do some stuff
        }
    }
}
