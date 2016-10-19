using System;
namespace DTcms.Web.Plugin.submits.Model
{
    /// <summary>
    /// �����
    /// </summary>
    [Serializable]
    public partial class submits_category
    {
        public submits_category()
        { }
        #region Model
        private int _id;
        private string _title = "";
        private string _field_ids = "";
        private int _is_default = 0;
        private int _sort_id = 99;
        private DateTime _add_time = DateTime.Now;
        /// <summary>
        /// ����ID
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// ����
        /// </summary>
        public string title
        {
            set { _title = value; }
            get { return _title; }
        }
        /// <summary>
        /// �����ļ�������
        /// </summary>
        public string field_ids
        {
            set { _field_ids = value; }
            get { return _field_ids; }
        }

        /// <summary>
        /// �Ƿ�Ĭ��
        /// </summary>
        public int is_default
        {
            set { _is_default = value; }
            get { return _is_default; }
        }
        /// <summary>
        /// ��������
        /// </summary>
        public int sort_id
        {
            set { _sort_id = value; }
            get { return _sort_id; }
        }
        /// <summary>
        /// ʱ��
        /// </summary>
        public DateTime add_time
        {
            set { _add_time = value; }
            get { return _add_time; }
        }
        #endregion Model

    }
}