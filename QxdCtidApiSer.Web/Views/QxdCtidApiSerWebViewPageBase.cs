using Abp.Web.Mvc.Views;

namespace QxdCtidApiSer.Web.Views
{
    public abstract class QxdCtidApiSerWebViewPageBase : QxdCtidApiSerWebViewPageBase<dynamic>
    {

    }

    public abstract class QxdCtidApiSerWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected QxdCtidApiSerWebViewPageBase()
        {
            LocalizationSourceName = QxdCtidApiSerConsts.LocalizationSourceName;
        }
    }
}