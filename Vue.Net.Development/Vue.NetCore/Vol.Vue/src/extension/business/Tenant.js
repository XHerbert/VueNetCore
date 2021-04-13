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
            // this.editFormOptions[1].push({
            //     colSize: 6,
            //     render: h => {
            //         return h(
            //             "div",
            //             {
            //                 style: {
            //                     "margin-left": "28px",
            //                     "line-height": "34px"
            //                 }
            //             },
            //             [
            //                 h(
            //                     "Select",
            //                     {
            //                         props: {
            //                             type: "primary"
            //                         },
            //                         style: {},
            //                         on: {
            //                             'on-change': () => {
            //                                 this.$Message.info(JSON.stringify($this.editFormFields));
            //                             }
            //                         }
            //                     },
            //                     "render(获取表单值)"
            //                 ),
            //                 h(
            //                     "Select",
            //                     {
            //                         props: {
            //                             type: "error"
            //                         },
            //                         style: {
            //                             "margin-left": "10px"
            //                         },
            //                         on: {
            //                             'on-change': (v) => {
            //                                 var i = v;
            //                                 //$this.resetEdit();
            //                                 this.selectOptions(i);
            //                             }
            //                         },
            //                         methods: {
            //                             selectOptions(v) {
            //                                 this.$Message.info(v);
            //                             }
            //                         }
            //                     },
            //                     [
            //                         h('Option', {
            //                             props: {
            //                                 value: '1',
            //                                 label: '北京'
            //                             }
            //                         }),
            //                         h('Option', {
            //                             props: {
            //                                 value: '2',
            //                                 label: '上海'
            //                             }
            //                         }),
            //                     ]
            //                 )
            //             ]
            //         );
            //     }
            // });
        }
    }
};
export default extension;