<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MustacheWebForm.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>MustacheWebForm</title>
    <script src="Javascripts/jquery-1.9.1.js"></script>
    <script src="Scripts/mustache.js"></script>
    <script type="text/javascript">
        //------------1.传统方式，拼接HTML  ----------------
        //$(document).ready(function () {
        //    var tableStudent = $("#tbody");
        //    $.ajax({
        //        cache: false,//(默认: true) jQuery 1.2 新功能，设置为 false 将不会从浏览器缓存中加载请求信息。
        //        type: "POST",
        //        url: "Default.aspx/GetAllStudent",
        //       // data: {},//没有参数的时候，这样设置,也可以不设置
        //        contentType: "application/json;charset=utf-8",
        //        dataType: "Json",
        //        success: function (data) {
        //            debugger;
        //            alert(data);
        //            //JSON.parse(data.d);
        //            var studentList = $.parseJSON(data.d);//JSON.parse用于从字符串中解析出Json对象
        //            //each，第一个参数是数据，第二个参数是回掉函数，回掉函数中第一个参数是索引，第二个是数据

        //            $.each(studentList, function (index, student) {
        //                var studentRow = "<tr>";
        //                studentRow += "<td>" + student.StudentId + "</td>";
        //                studentRow += "<td>" + student.Name + "</td>";
        //                studentRow += "<td>" + student.Registered + "</td>";
        //                studentRow += "</tr>";
        //                tableStudent.append(studentRow);
        //            });

        //        },
        //        error: function (xhr, ajaxOptions, thrownError) {
        //            alert('Failed to retrieve Student list.');
        //        }

        //    });


        //});
        //--------------1.end   ---------------------------

        $(document).ready(function () {
            var tableBody = $("#tbody");
            $.ajax({
                cache: false,
                url: "Default.aspx/GetAllStudent",
                type: "post",
                contentType: "application/json;charset=utf-8",
                dataType: "Json",
                success: function (data) {
                    debugger;
                    var studentList = $.parseJSON(data.d);
                    $.each(studentList, function (id, student) {

                        var template = $("#tempStudent").html();
                        var html = Mustache.render(template, student);
                        tableBody.append(html);
                    });

                },
                error: function (result) {
                    alert("error");
                }

            });


        })

    </script>
    <!--模板-->
    <script type="text/template" id="tempStudent">
        {{#Registered}}      
        <tr>
            <td>{{StudentId}}</td>
            <td>{{Name}}</td>
            <td>{{Registered}}</td>
        </tr>
        {{/Registered}}
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <table id="tblStudent" border="1" style="border-collapse: collapse">
            <thead>
                <tr>
                    <th>ID</th>
                    <th>Name</th>
                    <th>Registered</th>
                </tr>
            </thead>
            <tbody id="tbody">
            </tbody>

        </table>
    </form>
</body>
</html>
