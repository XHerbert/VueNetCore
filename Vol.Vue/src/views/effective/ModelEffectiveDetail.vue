<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/effective/ModelEffectiveDetail.js此处编写
 -->
<template>
    <div>
        <view-grid
                   ref="grid"
                   :columns="columns"
                   :detail="detail"
                   :editFormFields="editFormFields"
                   :editFormFileds="editFormFields"
                   :editFormOptions="editFormOptions"
                   :searchFormFields="searchFormFields"
                   :searchFormFileds="searchFormFields"
                   :searchFormOptions="searchFormOptions"
                   :table="table"
                   :extend="extend">
        </view-grid>
    </div>
</template>

<script>
    import extend from "@/extension/effective/ModelEffectiveDetail.js";
    import ViewGrid from "@/components/basic/ViewGrid.vue";
    var vueParam = {
        components: {
            ViewGrid
        },
        data() {
            return {
                table: {
                    key: 'ID',
                    footer: "Foots",
                    cnName: '行为列表',
                    name: 'ModelEffectiveDetail',
                    url: "/ModelEffectiveDetail/",
                    sortName: "ID"
                },
                extend: extend,
                editFormFields: {"TARGET_MODEL":"","ACTION":"","EFFECT_KEY":"","ACTION_VALUE":"","DESCRIPTION":"","EFFECT_VALUE":"","ORDER":""},
                editFormOptions: [[{"dataKey":"actionBehavior","data":[],"title":"动作类","field":"ACTION","type":"select"},
                               {"title":"动作值","field":"ACTION_VALUE","type":"text"},
                               {"title":"效果描述","field":"DESCRIPTION","type":"text"},
                               {"dataKey":"bimfaceMethods","data":[],"title":"BIM方法","field":"EFFECT_KEY","type":"select"},
                               {"title":"行为取值","field":"EFFECT_VALUE","type":"text"},
                               {"title":"效果排序","field":"ORDER","type":"number"},
                               {"title":"目标模型","field":"TARGET_MODEL","type":"text"}]],
                searchFormFields: {},
                searchFormOptions: [],
                columns: [{field:'TARGET_MODEL',title:'目标模型',type:'string',width:90,align:'left',sortable:true},
                       {field:'ACTION',title:'动作类',type:'short',bind:{ key:'actionBehavior',data:[]},width:90,align:'left'},
                       {field:'EFFECT_KEY',title:'BIM方法',type:'string',bind:{ key:'bimfaceMethods',data:[]},width:220,align:'left'},
                       {field:'ACTION_VALUE',title:'动作值',type:'string',width:220,align:'left'},
                       {field:'DESCRIPTION',title:'效果描述',type:'string',link:true,width:220,align:'left'},
                       {field:'EFFECT_VALUE',title:'行为取值',type:'string',width:90,align:'left'},
                       {field:'ORDER',title:'效果排序',type:'short',width:90,align:'left'},
                       {field:'ENABLE_FLAG',title:'有效标识',type:'short',width:90,align:'left'}],
                detail: {
                    cnName:"#detailCnName",
                    columns: [],
                    sortName: "",
                    key:""
                }
            };
        }
    };
    export default vueParam;
</script>
