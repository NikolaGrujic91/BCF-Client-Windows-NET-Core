// <auto-generated/>
//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


internal enum BC_Operation {
  operationUndefined = -1,
  operationIssueChangeStatus = 0,
  operationIssueChangeTitle,
  operationIssueChangeDescription,
  operationIssueChangeGuid,
  operationIssueChangeIndex,
  operationIssueChangeCreator,
  operationIssueChangeCreationDate,
  operationIssueChangeModifier,
  operationIssueChangeModificationDate,
  operationIssueChangeOwner,
  operationIssueChangePriority,
  operationIssueChangeType,
  operationIssueChangeVisibility,
  operationIssueChangeArea,
  operationIssueChangeMilestone,
  operationIssueChangeDeadline,
  operationIssueChangeClientParameters,
  operationIssueChangeExtendedData,
  operationIssueChangeIssueLocation,
  operationIssueCreateLabel = 50,
  operationIssueRemoveLabel,
  operationIssueCreateNotifiedUser,
  operationIssueRemoveNotifiedUser,
  operationIssueCreateApprover,
  operationIssueRemoveApprover,
  operationIssueCreateComment,
  operationIssueRemoveComment,
  operationIssueCreateViewpoint,
  operationIssueRemoveViewpoint,
  operationIssueCreateSnapshot,
  operationIssueRemoveSnapshot,
  operationIssueCreateIfcFile,
  operationIssueRemoveIfcFile,
  operationIssueCreateReferenceLink,
  operationIssueRemoveReferenceLink,
  operationIssueCreateBimSnippet,
  operationIssueRemoveBimSnippet,
  operationIssueCreateDocumentReference,
  operationIssueRemoveDocumentReference,
  operationIssueCreateRelatedIssue,
  operationIssueRemoveRelatedIssue,
  operationIssueActionEdit,
  operationIssueActionResolve,
  operationIssueActionClose,
  operationIssueActionReopen,
  operationIssueActionReactivate,
  operationIssueActionApprove,
  operationIssueActionDisapprove,
  operationIssueActionPublish,
  operationIssueActionSave,
  operationIssueCreateFavoritesSet,
  operationIssueRemoveFavoritesSet,
  operationCommentChangeText = 200,
  operationCommentChangeGuid,
  operationCommentChangeViewpoint,
  operationCommentChangeCreator,
  operationCommentChangeCreationDate,
  operationCommentChangeModifier,
  operationCommentChangeModificationDate,
  operationCommentActionEdit,
  operationCommentChangeExtendedData,
  operationViewpointChangeAll = 300,
  operationSnapshotChangeAll = 400,
  operation2DPointChangeAll = 410,
  operation3DPointChangeAll = 420,
  operationLineChangeAll = 430,
  operationClippingPlaneChangeAll = 440,
  operationIfcFileChangeAll = 450,
  operationAnnotationChangeAll = 460,
  operationDimensionChangeAll = 470,
  operationProjectCreateIssue = 500,
  operationProjectRemoveIssue,
  operationProjectActionPublish,
  operationProjectActionSave,
  operationProjectChangeExtendedData,
  operationProjectChangeProjectFileData,
  operationProjectChangeSmartViewData,
  operationProjectChangeCollisionDetectionData,
  operationProjectActionPublishProjectData
}
