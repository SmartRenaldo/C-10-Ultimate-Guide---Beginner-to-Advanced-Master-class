class Student
{
    //receive all subjects as an array using 'params' modifier
    public void DisplaySubjects(params string[] subjects)
    {
        for (int i = 0; i < subjects.Length; i++)
        {
            System.Console.WriteLine(subjects[i]);
        }
    }
}

class Params
{
    static void Main()
    {
        Student s = new Student();

        //access DisplaySubjects method
        s.DisplaySubjects("Git", "Github", "Slack", "Discord");

        System.Console.ReadKey();
    }
}