using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum Mode
{
    Stopped,
    Opening,
    Closing
}

public class Door
{
    static List<string> OpeningDoor(List<string> output, ref int counter)
    {
        if (counter != 5)
        {
            counter++;
        }
        output.Add(counter.ToString());
        return output;
    }

    static List<string> ClosingDoor(List<string> output, ref int counter)
    {
        if (counter != 0)
        {
            counter--;
        }
        output.Add(counter.ToString());
        return output;
    }

    public string ProcessEvents(string events)
    {
        Mode mode = Mode.Stopped;
        Mode lastMode = mode;
        
        var output = new List<string>();
        int counter = 0;
        foreach (char c in events)
        {
            if (c == 'O' && counter != 0 && mode != Mode.Stopped)
            {
                if (mode == Mode.Opening)
                {
                    output = ClosingDoor(output, ref counter);
                    mode = Mode.Closing;
                }
                else if (mode == Mode.Closing)
                {
                    output = OpeningDoor(output, ref counter);
                    mode = Mode.Opening;
                }
            }

            if (c == 'P')
            {
                if (counter != 0 && counter != 5)
                {
                    if (mode != Mode.Stopped)
                    {
                        lastMode = mode;
                        mode = Mode.Stopped;
                        output.Add(counter.ToString());
                    }
                    else
                    {
                        mode = lastMode;
                    }
                }

                if (counter == 5)
                {
                    mode = Mode.Closing;
                }
                else if (counter == 0)
                {
                    mode = Mode.Opening;
                }

                if (mode == Mode.Opening)
                {
                    output = OpeningDoor(output, ref counter);
                }
                else if (mode == Mode.Closing)
                {
                    output = ClosingDoor(output, ref counter);
                }
            }

            if (c == '.')
            {
                if (mode == Mode.Opening)
                {
                    output = OpeningDoor(output, ref counter);
                }
                else if (mode == Mode.Closing)
                {
                    output = ClosingDoor(output, ref counter);
                }
                else
                {
                    output.Add(counter.ToString());
                }
            }
        }
        return String.Join("", output);
    }
}
