using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using QxdCtidApiSer.Ctids;
using QxdCtidApiSer.Ctids.Dtos;

namespace QxdCtidApiSer.Web.Controllers
{
    public class CtidsController : QxdCtidApiSerControllerBase
    {
        private readonly ICtidRecogAppService _ctidRecogAppService;

        public CtidsController(ICtidRecogAppService ctidRecogAppService)
        {
            _ctidRecogAppService = ctidRecogAppService;
        }

        /// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var ctidRecogs = _ctidRecogAppService.GetCtidRecogs();

            return View(ctidRecogs);
        }

        /// <summary>
        /// 2 项信息+人像 0x42
        /// </summary>
        /// <param name="name">身份证姓名</param>
        /// <param name="idCardNo">身份证号码</param>
        /// <param name="file">人像</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult GetTwoAndFace(string name, string idCardNo, byte[] file)
        {
            var twoAndFaceInput = new GetTwoAndFaceInput();

            //test data
            twoAndFaceInput.Name = "王海滨";
            twoAndFaceInput.IdCardNo = "362330198209067199";
            twoAndFaceInput.PhotoBuffer = "/9j/4AAQSkZJRgABAQEAYABgAAD/2wBDAAgGBgcGBQgHBwcJCQgKDBQNDAsLDBkSEw8UHRofHh0aHBwgJC4nICIsIxwcKDcpLDAxNDQ0Hyc5PTgyPC4zNDL/2wBDAQkJCQwLDBgNDRgyIRwhMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjL/wgARCABZAFADASIAAhEBAxEB/8QAGwAAAgIDAQAAAAAAAAAAAAAAAwUEBgACBwH/xAAYAQADAQEAAAAAAAAAAAAAAAABAgMABP/aAAwDAQACEAMQAAABtu4yI3giU1g+LRQuvUtapbU0cMoZWZ5mLRZsdUGiqrEkzqeiVS3PLYe8IBhi7CrGNGOtSK/MS2O6/MpDferM6we+K9ArfRZurhhBhx7XozJengBKA7dY8Aapkls6y5j02eK8WQ6B1kSik2Fqobikpajp0ZG5uHp2Y0tP0zNuch6Zg3Mmd6Kd/8QAKBAAAgIBAgUEAgMAAAAAAAAAAgMBBAAREgUQEyEiFDEyNRUwM0FC/9oACAEBAAEFAt/l2LNsxhtBcHfUvFX0N5zn+tvnpjDha3ETJKc1zh92YLlMc7nlHpwgG0InPx56MSaJSfUTk82jqdpwRK5OVseW90y+qA7Fzm+epr3ycIYLJiIAlCcysduWLQoIygWEkuptsYAvEvfHBrkTsFR6vZcFZWLQvseoF9qZ8t2bs+UPrxM9ligpFZvbENa3WjvK01sw+WznVwGbpY5+RBFKo1U8Xia63euOjXnMPJ0CI2iI+GRLbZV9ZJemD2i9d6mJtkvKjBYdgxG3YbvwJzhT+lan2c1SYs3jdmnbOGfYWQH1bPM9NM/s+K2CAjI5AJZM8uG/Yu/k/Qv5/wD/xAAfEQACAgICAwEAAAAAAAAAAAAAAQIRAxIQIBMhIjH/2gAIAQMBAT8B6a8IpDVPjYg7EjI0hStnkMWX6ov0ZoT2IxSFjtkEo/hZKVlCXX//xAAdEQACAgMAAwAAAAAAAAAAAAAAAQIREBIhAyBB/9oACAECAQE/ARFIar0TPmNSXMRTY4UjQnDmPG40SfDZJEulCRfCy82f/8QALxAAAQMCBAUCBAcAAAAAAAAAAQACEQMhEBIxUSAiQWFxMrFygZHwBBMjJDBSYv/aAAgBAQAGPwI+cLL9QwhHMozZT/rgCPnAuKL3XxFGoZafSduJjB1KywrLS4Qn6pj9xPDSOxV3PHhZplc1Ys7L+xnVNbsIwDe6ON1ZSQFlFpwa0icypjq42TnNqRfZWqj6KXvBbgf3Dmr1Zu6k6BRkc7wmG4A3X4bKerkeCzGRgS31FGcsqYYmOLAACnNi0m6tC1Tm5r9FGZS4yo0UZPms1Qym+VU+IrMTZaW2VWps2ETj+VTPINe65+YJha6VW+M+6aNkUWHSpb54S9yLWcrPdThS++iqnU5z7omVMWUhBoyt7qXEk91ACjCl99P4gv/EACUQAQACAgIBBAMAAwAAAAAAAAEAESExQVGBEGFxoZGx0TDh8P/aAAgBAQABPyGifSJRahsrOmEUC9x4WXNcRDwWF+lem3zzB3mNsThTi0Kjnp1jwnLr0S5RXyR2+hYboKErMdRYfpjaH3BzHjTiEUKTp6a+T9x2+nmx/Epa2sWo3FHFwDVr0uMaQQA5uEDxRpGwZH8JRobzLlMM0USVIUS6Ej1Lkyw16IBYxUYJdHwLlqLU/wDLjRDU0Vqe7UdIuN1ZibSx32hi+C5WGNaj+wIlTdPeGe1O+3UPzsp3K9yijif3GRKWjq4BT21g+4FeURVlTxLKoaKrEHl/AQKW3zbxN/0gWC5YvUAq+ks6hsy3dRJoeo3BDYPC2+ZaaCsA6nCJzfMd2B1MDR1c+ZgNX3n/AEwWSYWMxYiI7PIOX8jlB+fJKaS9Dr5JdCXwlu0sgIDlu2VPwgp6DL2aihyYPthg199wL2Nelzqtv8oTeH+MpSoXqXOpYMy0zBHcs4ApJliV62qZonfsHbK2hKNRABjx+7+03f4h/9oADAMBAAIAAwAAABBURkOx0IocRdxi0OqZc1Vo1bLqbyw/z//EABsRAAMAAwEBAAAAAAAAAAAAAAABESExQVEQ/9oACAEDAQE/EB40Vmx06UUcsiMBRN1EnhhGkY9g0TyUROnIYpaHi9G59ESIL2aCJtRDfx17ZVJ8/8QAHBEBAQEAAgMBAAAAAAAAAAAAAQARITEQQVFx/9oACAECAQE/ENge4YtEPhn2XYWPsRYO2wPEIP7sJkNQfbuO7lTwHc0ML1Z8s6WzuPSELXfD/8QAJRABAAICAgICAgIDAAAAAAAAAQARITFBUWGBcZGhscHwEDDR/9oACAEBAAE/EGsRWM5wzeBJYW/0cxsiUbfVZgQMLtE9o7WZR+AdRBF7jXUKN3iWUDQVfcKkERMZ3GgcZekgwG14IsC2WmANHRL4RM4ma257Y/DIHPAnpiY/xhtDX7iE1cwC4vCbusQwAASbmzIZd9kavG2YPj+4gJpYSOdyxfd0UGJUeH9sIvugxgbpKeLRGNtGherPiULQtjLMBMAUfQeIw9oaFH7mgwT0VFaOYUQGLyNM/wARqBRDTpuAllma1CCkdkAkosKqbKQXyl0IQpWbKfxDQdESjBtMZoi/kkOLEvor3NbhzW1a7S8F+Uj/ADGl7IXY8IVUcwVcpXTLInUMahKuK0ot6lSB1nV6IBM4mA8ZF+pTaea6rLUtDqlKpVfhBBeS77hXpLcI1qLjbWE7IOobtjZjg16wnAPLCBrFIsaA1Qj81VfUpy0VQt+DbDlApYTkVfxuIBQkuKruHLcKsPaq5jQ0652uAgMeLpyHXzLflKXS5fD3dOpQApxkD1FKsVEvSmqDw26mKdlvD5fxCIBQAApgA1CJQBHAw445lLzeAzKOHGlFXFoweQieRjS9jW1f+0o7chBJoWzXURINLqF2vVeD9uep5AI/SXcKs45DrXA/MvPO/DeRwTPlVtSO30EZ11h+4GQYLhF+1p7JYs0VKiywb8AczGGQDi8vB4JYUQuXmA6lLFENMX2d6h+zEXjscfcQao8OiuPiK2D25WnnuZ2tAMUmcPepUCG1v3nB6JmaMosAKrs1gbTgO4rlXW7zmIjkuXG5/wBWH8qf/9k=";



            //twoAndFaceInput.Name = name;
            //twoAndFaceInput.IdCardNo = idCardNo;
            //twoAndFaceInput.PhotoBuffer = Convert.ToBase64String(file);


            var twoAndFace = _ctidRecogAppService.GetTwoAndFace(twoAndFaceInput);

            return Json(twoAndFace);
        }


        /// <summary>
        /// 4 项信息+人像 0x42
        /// </summary>
        /// <param name="name">身份证姓名</param>
        /// <param name="idCardNo">身份证号码</param>
        /// <param name="beginDate"></param>
        /// <param name="endDate"></param>
        /// <param name="file">人像</param>
        /// <returns>认证结果</returns>
        [HttpPost]
        public ActionResult GetFourAndFace(string name, string idCardNo, string beginDate, string endDate, byte[] file)
        {
            var fourAndFaceInput = new GetFourAndFaceInput();

            //test data
            fourAndFaceInput.Name = "王海滨";
            fourAndFaceInput.IdCardNo = "362330198209067199";
            fourAndFaceInput.UserLifeBegin =

            fourAndFaceInput.PhotoBuffer = "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";



            //twoAndFaceInput.Name = name;
            //twoAndFaceInput.IdCardNo = idCardNo;
            //twoAndFaceInput.PhotoBuffer = Convert.ToBase64String(file);


            var twoAndFace = _ctidRecogAppService.GetFourAndFace(fourAndFaceInput);

            return Json(twoAndFace);
        }

        /// <summary>
        /// 人像+网证 0x06
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult GetFaceAndWz(GetFaceAndWzInput input)
        {

            var twoAndFaceInput = new GetTwoAndFaceInput();

            //test data
            twoAndFaceInput.Name = "王海滨";
            twoAndFaceInput.IdCardNo = "362330198209067199";
            twoAndFaceInput.PhotoBuffer = "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";



            //twoAndFaceInput.Name = name;
            //twoAndFaceInput.IdCardNo = idCardNo;
            //twoAndFaceInput.PhotoBuffer = Convert.ToBase64String(file);


            var twoAndFace = _ctidRecogAppService.GetTwoAndFace(twoAndFaceInput);
            return Json("");
        }
    }
}