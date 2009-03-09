using System;
using System.Collections.Generic;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NetSqlAzMan.Interfaces;
using NetSqlAzMan.SnapIn.DirectoryServices.ADObjectPicker;
using NetSqlAzMan.SnapIn.DirectoryServices;
using NetSqlAzMan;

namespace NetSqlAzMan.SnapIn.Forms
{
    internal class GenericMemberCollection : List<GenericMember>
    {
        internal bool Remove(string objectSid)
        {
            foreach (GenericMember m in this)
            {
                if (m.sid.StringValue == objectSid)
                {
                    this.Remove(m);
                    return true;
                }
            }
            return false;
        }

        internal bool ContainsByObjectSid(string objectSid)
        {
            foreach (GenericMember m in this)
            {
                if (m.sid.StringValue == objectSid)
                {
                    return true;
                }
            }
            return false;
        }

        internal bool ContainsByName(string name)
        {
            foreach (GenericMember m in this)
            {
                if (String.Compare(m.Name, name, true)==0)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
