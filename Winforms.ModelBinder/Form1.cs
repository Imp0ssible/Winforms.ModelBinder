using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Winforms.ModelBinder
{
    public partial class Form1 : Form
    {
        private readonly ModelBinder<Car> _binder = new ModelBinder<Car>();
        private readonly IList<EngineType> _engineTypes = EngineType.GetEngineTypes().ToList();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _binder.Bind(CarName, car => car.Name)
                   .Bind(Manufacturer, car => car.Manufacturer)
                   .Bind(IsDiesel, car => car.IsDiesel)
                   .Bind(EngineTypes, car => car.EngineTypeId, _engineTypes);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var car = _binder.Current;

            MessageBox.Show(car.ToString());
        }
    }
}
