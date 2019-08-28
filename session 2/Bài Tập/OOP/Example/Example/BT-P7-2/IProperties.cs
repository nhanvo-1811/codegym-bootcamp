using System;
using System.Collections.Generic;
using System.Text;

namespace Example
{
    public interface IProperties
    {
        int Id { get; set; }
        string Name { get; set; }
        DateTime PublishDate { get; set; }
        string Director { get; set; }
        string Subtitle { get; set; }
        float AverageRate { get; }
    }
}
