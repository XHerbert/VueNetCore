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
            //this.setFiexdSearchForm(true);
            //this.detailOptions.clickEdit = true;

            //下面的面代码不是必须项，自己根据需要实现
            //this.detailOptions.beginEdit = (row, column, index) => {
            //console.log("开始编辑" + JSON.stringify(row))
            //return true;
            //}
            //this.detailOptions.endEditBefore = (row, column, index) => {
            //console.log("结束编辑前" + JSON.stringify(row))
            //return true;
            //}
            //this.detailOptions.endEditAfter = (row, column, index) => {
            //console.log("结束编辑后,这里会进行row字段验证" + JSON.stringify(row))
            //return true;
            //}
        }
    }
};
export default extension;