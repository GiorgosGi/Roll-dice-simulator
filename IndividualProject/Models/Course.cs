using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject.Models
{
    class Course
    {
        private string _title;  
        private string _stream;
        private string _type;
        private string _start_date;
        private string _end_date;

        public string Title  
        {
            get { return (this._title); }
            set { this._title = value.ToUpper(); }
        }

        public string Stream
        {
            get { return (this._stream); }
            set { this._stream = value.ToUpper(); }
        }

        public string Type
        {
            get { return (this._type); }
            set { this._type = value.ToUpper(); }
        }

        public string Start_Date
        {
            get { return (this._start_date); }
            set { this._start_date = value.ToUpper(); }
        }

        public string End_Date
        {
            get { return (this._end_date); }
            set { this._end_date = value.ToUpper(); }
        }

        public override string ToString()      
        {
            return ($"Title: {_title}\tStream: {_stream}\tType: {_type}\tStart Date: {_start_date}\tEnd Date: {_end_date} "); 
        }
    }
}
