using System;
using System.Collections.Generic;
using System.Text;
using Android;
using Android.Content;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Kankan.Wheel.Widget;
using Kankan.Wheel.Widget.Adapters;

namespace MonoDroid.KanKanWheel
{
   public class JuzzPigWheelView:WheelView
    {


    
       public JuzzPigWheelView(Context p0, IAttributeSet p1, int p2) : base(p0, p1, p2)
       {
       }

       public JuzzPigWheelView(Context p0, IAttributeSet p1) : base(p0, p1)
       {
       }

       public JuzzPigWheelView(Context p0) : base(p0)
       {
       }

       public class PopupSelectWheelAdapter : AbstractWheelAdapter
       {
           public class WheelItemInfo
           {
               /// <summary>
               /// 自动编号
               /// </summary>
               public int Id { set; get; }

               /// <summary>
               /// 名称
               /// </summary>
               public string Name { set; get; }
           }

           private List<WheelItemInfo> _mDataSource;
           private Context _mContext;

           public PopupSelectWheelAdapter(Context context, List<WheelItemInfo> source)
           {
               this._mContext = context;
               this._mDataSource = source;
           }

           public override int ItemsCount
           {
               get { return _mDataSource.Count; }
           }

           public WheelItemInfo GetItemData(int p0)
           {
               if (this._mDataSource == null || this._mDataSource.Count == 0 || p0 >= this._mDataSource.Count)
               {
                   return null;
               }
               return this._mDataSource[p0];
           }

           public string GetItemText(int p0)
           {
               return this._mDataSource[p0].Name;
           }

           public override View GetItem(int p0, View p1, ViewGroup p2)
           {
               /*
               var view = LayoutInflater.From(this._mContext)
                   .Inflate(Resource.Layout., null);

               view.LayoutParameters = new ViewGroup.LayoutParams(ViewGroup.LayoutParams.WrapContent,
                   this._mContext.GetPixsFromDips(40));
               var tvTitle = view.FindViewById<TextView>(Resource.Id.itemTitle);
               tvTitle.Text = GetItemText(p0);
               return view;*/
               
                var view = new TextView(this._mContext);
               // view.LayoutParameters = new ViewGroup.LayoutParams(ViewGroup.LayoutParams.WrapContent, this._mContext.GetPixsFromDips(40));
                
                view.Gravity = GravityFlags.CenterVertical;
                view.Text = _mDataSource[p0].Name;
                //throw new NotImplementedException();
                return view;
           }
       }

    }
}
