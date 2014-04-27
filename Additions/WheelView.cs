using System;
using System.Collections.Generic;
using System.Text;
using Android.Graphics;

namespace Kankan.Wheel.Widget
{
    public static class WheelViewExtensions
    {
        /// <summary>
        /// 清除阴影
        /// </summary>
        /// <param name="view"></param>
        public static void ClearShadowColor(this WheelView view)
        {
            view.SetShadowColor(Color.ParseColor("#00000000"), Color.ParseColor("#00000000"), Color.ParseColor("#00000000"));
        }
    }
    public partial class WheelView
    {
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="newValue"></param>
        public void NotifyChange(int newValue)
        {
          //  this.SetDefaultItem(newValue, true);
            this.NotifyChangingListeners(-1, newValue);

        }
        /// <summary>
        /// 重写选择指定行，把属性赋值和SetCurrentItem放在一起，免得出问题
        /// </summary>
        /// <param name="pos"></param>
        protected void SetDefaultItem(int pos)
        {

            this.CurrentItem = pos;
            this.SetCurrentItem(pos, true);
        }
    }
}
