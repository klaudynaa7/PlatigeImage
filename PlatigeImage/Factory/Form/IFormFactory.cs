namespace PlatigeImage.Factory.FormFactory
{
    public interface IFormFactory
    {
        T Create<T>() where T : Form;
    }
}
