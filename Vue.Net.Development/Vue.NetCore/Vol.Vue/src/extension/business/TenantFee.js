/*
 * Author：xuhbd
 * Contact：xuhb-c@glodon.com
 * 此处是对表单的方法，组件，权限操作按钮等进行任意扩展(方法扩展可参照SellOrder.js)
 */

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
            this.columns.forEach(x => {
                // if (x.field == "Variety") {
                //设置table有数据源的列为正常显示(不显示背景颜色)
                //   x.normal = true;
                // }
                console.log(x);
                if (x.field == "Receivable" ||
                    x.field == "PreReceivable" ||
                    x.field == "UnPaidRent" ||
                    x.field == "ActualPaidRent" ||
                    x.field == "Crash" ||
                    x.field == "FeeFromBank" ||
                    x.field == "NoFeeToBank" ||
                    x.field == "OffsetPreReceivable") {
                    //设置table有数据源的列为正常显示(并设置自定义文字颜色)
                    //x.normal = true;
                    //根据不同的值，定义不同的样式(如：文字颜色)
                    x.cellStyle = (row, column) => {

                        return { color: "#ff8a00", cursor: "pointer" };
                    };
                    //绑定点击事件
                    x.click = (row, column, event) => {
                        this.$Message.info(row.Receivable + " ");
                        row.Receivable = "￥" + row.Receivable;
                    };
                }
            });
        }
    }
};
export default extension;