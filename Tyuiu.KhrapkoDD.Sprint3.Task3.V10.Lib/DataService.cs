using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KhrapkoDD.Sprint3.Task3.V10.Lib
{
    public class DataService : ISprint3Task3V10
    {
        public string DeleteCharInString(string value, char item)
        {
            int count = 0;
            foreach (char chr in value)
            {
                if (chr == item)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
