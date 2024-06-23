$(function () {
    var l = abp.localization.getResource('GVABP');

    var createModal = new abp.ModalManager(abp.appPath + 'GiangViens/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'GiangViens/EditModal');

    var dataTable = $('#GiangViensTable').DataTable(
        abp.libs.datatables.normalizeConfiguration({
            serverSide: true,
            paging: true,
            order: [[1, "asc"]],
            searching: false,
            scrollX: true,
            ajax: abp.libs.datatables.createAjax(acme.gVABP.giangViens.giangVien.getList),
            columnDefs: [

                {
                    title: l('Actions'),
                    rowAction: {
                        items:
                            [
                                {
                                    text: l('Edit'),
                                    action: function (data) {
                                        editModal.open({ id: data.record.id });
                                    }
                                },

                                {
                                    text: l('Delete'),
                                    confirmMessage: function (data) {
                                        return l('GiangVienDeletionConfirmationMessage', data.record.name);
                                    },
                                    action: function (data) {
                                        acme.gVABP.giangViens.giangVien
                                            .delete(data.record.id)
                                            .then(function () {
                                                abp.notify.info(l('Successfully Deleted'));
                                                dataTable.ajax.reload();
                                            });
                                    }
                                }

                            ]
                    }
                },

                {
                    title: l('Name'),
                    data: "name"
                },
                {
                    title: l('Type'),
                    data: "type",
                    render: function (data) {
                        return l('Enum:SubjectType.' + data);
                    }
                },
                {
                    title: l('Birthday'),
                    data: "birthday",
                    render: function (data) {
                        return luxon
                            .DateTime
                            .fromISO(data, {
                                locale: abp.localization.currentCulture.name
                            }).toLocaleString();
                    }
                },
                {
                    title: l('Salary'),
                    data: "salary"
                },
                {
                    title: l('CreationTime'),
                    data: "creationTime",
                    render: function (data) {
                        return luxon
                            .DateTime
                            .fromISO(data, {
                                locale: abp.localization.currentCulture.name
                            }).toLocaleString(luxon.DateTime.DATETIME_SHORT);
                    }
                }
            ]
        })
    );

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewGiangVienButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
