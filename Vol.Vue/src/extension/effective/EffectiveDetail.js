//author:jxx
//此处是对表单的方法，组件，权限操作按钮等进行任意扩展(方法扩展可参照SellOrder.js)
let extension = {
    components: {//动态扩充组件或组件路径
        //表单header、content、footer对应位置扩充的组件
        gridHeader: '',//{ template: "<div>扩展组xx件</div>" },
        gridBody: '',
        gridFooter: '',
        //弹出框(修改、编辑、查看)header、content、footer对应位置扩充的组件
        modelHeader: '',
        modelBody: '',
        modelFooter: ''
    },
    buttons: { view: [], box: [], detail: [] },//扩展的按钮
    methods: {//事件扩展
        onInit() {

            // this.detailOptions.clickEdit = true;
            // //动态修改table并给列添加事件
            // this.columns.forEach(x => {
            //     if (x.field == "ACTION_VALUE" && x.ACTION_VALUE.indexOf("#") > -1) {
            //         if (x.ACTION_VALUE.indexOf("_") > -1) return;
            //         x.formatter = (row) => {
            //             return '<span style="padding: 4px;border-radius:6px;background-color:' + row.ACTION_VALUE + ';color:#FFA500">' + row.ACTION_VALUE + '</span>';
            //         }
            //     }

            //     //绑定点击事件
            //     x.click = (row, column, event) => {
            //         this.$Message.info(row.ACTION_VALUE);
            //     };
            // })
        }
    }
};
export default extension;