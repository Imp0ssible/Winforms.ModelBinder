using System;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Winforms.ModelBinder
{
    public class ModelBinder<T> : BindingSource where T : class, new()
    {
        /// <summary>
        /// Initializes a new instance of the Genius.Payroll.UI.Controls.ModelBinder class
        /// and adds the new T to DataSource
        /// </summary>
        public ModelBinder(bool createNewModel = true)
        {
            if (createNewModel)
                DataSource = new T();
        }

        /// <summary>
        /// Initializes a new instance of the Genius.Payroll.UI.Controls.ModelBinder class
        /// and adds the model to DataSource
        /// </summary>
        public ModelBinder(T model)
        {
            DataSource = model;
        }

        /// <summary>
        /// Gets the name of the current member from expression
        /// </summary>    
        private static string GetMemberName(Expression<Func<T, object>> expression)
        {
            return String.Join(".", expression.ToString().Split('.').Where((source, index) => index != 0)).TrimEnd(')');
        }

        /// <summary>
        /// Gets the current item in the list
        /// </summary>
        public new T Current { get { return (T)base.Current; } }

        /// <summary>
        /// Creates a binding that binds the specified control property 
        /// to the specified data member
        /// </summary>
        public ModelBinder<T> Bind(TextBox control, Expression<Func<T, object>> member, string propertyName = "Text")
        {
            control.DataBindings.Clear();
            control.DataBindings.Add(propertyName, this, GetMemberName(member), true, DataSourceUpdateMode.OnPropertyChanged);

            return this;
        }

        /// <summary>
        /// Creates a binding that binds the specified control property 
        /// to the specified data member
        /// </summary>
        public ModelBinder<T> Bind(CheckBox control, Expression<Func<T, object>> member, string propertyName = "Checked")
        {
            control.DataBindings.Clear();
            control.DataBindings.Add(propertyName, this, GetMemberName(member), true, DataSourceUpdateMode.OnPropertyChanged);

            return this;
        }

        /// <summary>
        /// Creates a binding that binds the specified control property 
        /// to the specified data member
        /// </summary>
        public ModelBinder<T> Bind(ComboBox control, Expression<Func<T, object>> member, object dataSource, string displayMember = "Name", string valueMember = "Id", string propertyName = "SelectedIndex")
        {
            control.DisplayMember = displayMember;
            control.ValueMember = valueMember;
            control.DataSource = dataSource;

            control.DataBindings.Clear();
            control.DataBindings.Add(propertyName, this, GetMemberName(member), true, DataSourceUpdateMode.OnPropertyChanged);

            return this;
        }
    }
}
