(function ($) {
    function HomeIndex() {
        var $this = this;

        function initBook() {
            $("#Content").summernote({
                focus: true,
                height: 150,
                codemirror: {
                    theme: 'united'
                }
            });
        }
        $this.init = function () {
            initBook();
        }
    }
    $(function () {
        var self = new HomeIndex();
        self.init();
    })

}(jQuery));