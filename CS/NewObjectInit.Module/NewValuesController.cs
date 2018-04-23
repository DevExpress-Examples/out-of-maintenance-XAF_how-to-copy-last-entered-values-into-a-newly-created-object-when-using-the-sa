using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.Persistent.BaseImpl;

namespace NewObjectInit.Module
{
    public partial class NewValuesController : ViewController
    {
        public NewValuesController()
        {
            InitializeComponent();
            RegisterActions(components);
        }

        DetailViewController detailViewController;

        private void ViewController1_Activated(object sender, EventArgs e)
        {
            detailViewController = Frame.GetController<DetailViewController>();
            detailViewController.SaveAndNewAction.Executing += new CancelEventHandler(SaveAndNewAction_Executing);
            Frame.ViewChanged += new EventHandler<ViewChangedEventArgs>(Frame_ViewChanged);
        }

        void Frame_ViewChanged(object sender, ViewChangedEventArgs e)
        {
            if (person != null && View.CurrentObject != null && View.CurrentObject.GetType() == typeof(Person))
            {
                Person current = (Person)View.CurrentObject;
                current.FirstName = person.FirstName;
                current.LastName = person.LastName;
                person = null;
            }
        }

        static Person person;

        void SaveAndNewAction_Executing(object sender, CancelEventArgs e)
        {
            if (View.CurrentObject.GetType() == typeof(Person))
            {
                person = (Person)View.CurrentObject;
            }
        }


    }
}
