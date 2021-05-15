using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_hw5
{
    class GeneralizedFigure : IEnumerable
    {
        public List<Figure> Figures { get; set; }

        public GeneralizedFigure()
        {
            Figures = new List<Figure>();
        }
        public void Add(Figure figure)
        {
            Figures.Add(figure);
        }
    public void Draw()
    {
        foreach (Figure item in Figures)
        {
            item.Draw();
        }
    }

        public IEnumerator GetEnumerator()
        {
            return Figures.GetEnumerator();
        }
    }
}
