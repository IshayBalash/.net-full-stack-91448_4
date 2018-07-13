using System.Web.Http;

namespace _00_basic_web_api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API routes
            config.MapHttpAttributeRoutes();


            // MapHttpRoute - Maps the specified route template and sets default route values.
            config.Routes.MapHttpRoute(
                name: "DefaultApi",   //שם להגדרת הקונפיגורציה של הניתוב הנוכחי, לכל הגדרת ניתוב חייב להיות שם ייחודי
                routeTemplate: "api/{controller}/{id}",  //הגדרת הלינק לניתוב
                defaults: new { id = RouteParameter.Optional }  //אפשרות לתת ערכים אופציונליים עבור הפרמטרים של הניתוב
            );
        }
    }
}


/*
   routeTemplate: "api/{controller}/{id}"
     api - חלק קבוע בלינק, נוסיף אותו אחרי הקידומת של כתובת השרת
     {controller} - זהו חלק שחובה להוסיף ללינק - אבל הוא ישתנה בהתאם לקונטרולר אליו הלקוח ירצה לפנות
     Controllerהשם של הקונטרולר יהיה שם המחלקה ללא הסיומת של ה
     {id} - חלק אופציונלי בלינק - רק כאשר נרצה להעביר פרמטר נשתמש ביכולת זו
*/
