using System.Collections.Generic;
using System.Data;
using System.IO;
using DTcms.Common;

namespace DTcms.Web.Plugin.submits.BLL
{
	/// <summary>
	/// Ƶ�������
	/// </summary>
	public partial class submits_category
	{
        private readonly DTcms.Model.siteconfig siteConfig = new DTcms.BLL.siteconfig().loadConfig(); //���վ��������Ϣ
        private readonly DAL.submits_category dal;

		public submits_category()
		{
            dal = new DAL.submits_category(siteConfig.sysdatabaseprefix);
        }
		#region ��������========================================

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int id)
		{
			return dal.Exists(id);
		}



        /// <summary>
        /// �����������
        /// </summary>
        public string GetTitle(int id)
        {
            return dal.GetTitle(id);
        }
        /// <summary>
        /// �����������
        /// </summary>
        public string GetIds(int id)
        {
            return dal.GetIds(id);
        }
        /// <summary>
        /// ����Ƶ�����������Ŀ¼��
        /// </summary>
        public string GetBuildPath(int id)
        {
            return dal.GetBuildPath(id);
        }

		/// <summary>
		/// ����һ������
		/// </summary>
		public int Add(Model.submits_category model)
		{
            int newCategoryId = dal.Add(model);          
            return newCategoryId;
		}

        /// <summary>
        /// �޸�һ������
        /// </summary>
        public bool UpdateField(int id, string strValue)
        {
            return dal.UpdateField(id, strValue);
        }

        /// <summary>
        /// �޸�һ������
        /// </summary>
        public bool UpdateField(string build_path, string strValue)
        {
            return dal.UpdateField(build_path, strValue);
        }

		/// <summary>
		/// ����һ������
		/// </summary>
		public bool Update(Model.submits_category model)
		{
            Model.submits_category oldModel = dal.GetModel(model.id);
            if (dal.Update(model))
            {                            
                return true;
            }
            return false;
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public bool Delete(int id)
		{
			return dal.Delete(id);
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public Model.submits_category GetModel(int id)
		{
			return dal.GetModel(id);
		}



		/// <summary>
		/// ���ǰ��������
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}

        /// <summary>
        /// ��ò�ѯ��ҳ����
        /// </summary>
        public DataSet GetList(int pageSize, int pageIndex, string strWhere, string filedOrder, out int recordCount)
        {
            return dal.GetList(pageSize, pageIndex, strWhere, filedOrder, out recordCount);
        }

		#endregion

        #region ��չ����========================================
        /// <summary>
        /// ����Ĭ�ϵ�����Ŀ¼
        /// </summary>
        public string GetDefaultPath()
        {
            DataTable dt = GetList(1, "is_default=1", "sort_id asc,id desc").Tables[0];
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["build_path"].ToString();
            }
            return string.Empty;
        }



        /// <summary>
        /// ��������б�
        /// </summary>
        public List<Model.submits_category> DataTableToList(DataTable dt)
        {
            List<Model.submits_category> modelList = new List<Model.submits_category>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Model.submits_category model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Model.submits_category();
                    if (dt.Rows[n]["id"].ToString() != "")
                    {
                        model.id = int.Parse(dt.Rows[n]["id"].ToString());
                    }
                    model.title = dt.Rows[n]["title"].ToString();
                    model.field_ids = dt.Rows[n]["field_ids"].ToString();
                    if (dt.Rows[n]["is_default"].ToString() != "")
                    {
                        model.is_default = int.Parse(dt.Rows[n]["is_default"].ToString());
                    }
                    if (dt.Rows[n]["sort_id"].ToString() != "")
                    {
                        model.sort_id = int.Parse(dt.Rows[n]["sort_id"].ToString());
                    }
                    modelList.Add(model);
                }
            }
            return modelList;
        }



        #endregion
    }
}

