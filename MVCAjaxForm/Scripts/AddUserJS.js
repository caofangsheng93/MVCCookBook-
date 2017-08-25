(function ($) {
    function AddUser() {
        var $this = this;
        function initUser() {
            var formAddUser = new Global.FormHelper($("#frm-add-user"), { updateTargetId: "validation-summary" });
        }
        $this.init = function () {
            initUser();
        }
    }
    $(function () {
        var self = new AddUser();
        self.init();

    })


}(jQuery))