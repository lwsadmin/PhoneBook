
(function () {
    $(function () {
        var pesonService = abp.services.app.person;
        var _$modal = $("#PersonCreateModal");
        var _$form = _$modal.find("form");
        _$form.find("button[type='submit']").click(function (e) {
            e.preventDefault();
            debugger;
            if (!_$form.valid()) {
                return;
            }

            var personEditDto = _$form.serializeFormToObject();
            abp.ui.setBusy(_$form);
            pesonService.createOrEdit(personEditDto).done(function () {
                _$modal.modal('hide');
                Refresh();
            }).always(function () {
                abp.ui.clearBusy(_$form);
            });
        });

        $("#PersonCreateModal").on("hide.bs.modal", function () {
            _$form[0].reset();
        });
        $("#RefreshButton").click(function () {
            Refresh();
        });
        function Refresh() {
            window.location.reload();
        }

        $(".delete-role").click(function () {
            var id = $(this).attr("data-id");
            var name = $(this).attr("data-name");
            abp.message.confirm("确定要删除联系人【" + name + "】吗?", function (isConfirm) {
                if (isConfirm) {
                    pesonService.deletePerson(id).done(function () {
                        Refresh();
                    });
                }
            });
        });

        $(".edit-role").click(function (e) {
            e.preventDefault();

            var id = $(this).attr("data-id");

            pesonService.getPersonBuyID(id).done(function (data) {
                debugger;
                $("input[name='Id']").val(id);
                $("input[name='Name']").val(data.name).parent().addClass("focused");
                $("input[name='Email']").val(data.email).parent().addClass("focused");
                $("#Address").val(data.address).parent().addClass("focused");
            });

            _$modal.modal('show');
        });
    });


})();