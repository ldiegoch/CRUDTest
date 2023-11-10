(function ($) {

    $.widget("custom.categoryForm", {
        _create: function () {
            let self = this;
            self.checkName();
            $('input[type="text"]',this.element).change(e => {
                let txt = e.target.value;
                self.checkName();
            });
        },
        checkName: function () {
            let name = $('input[type="text"]', this.element).prop("value");
            if (name.length > 1) {
                this.disableSave(false);
            } else {
                this.disableSave(true);
            }
        },
        disableSave: function (enabled = true) {
            $('input[type="submit"]',this.element).prop('disabled', enabled);
        }
    })

}(jQuery));

// Usage example:
$(".form-fields").categoryForm();